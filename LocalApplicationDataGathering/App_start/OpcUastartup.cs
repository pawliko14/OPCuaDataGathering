using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using Opc.Ua;
using Opc.Ua.Client;
using Siemens.UAClientHelper;

namespace LocalApplicationDataGathering
{
    public sealed class OpcUastartup
    {
        private List<string> plc_variables;

        //singleton
        private OpcUastartup()
        {
            plc_variables = new List<string>();


        }
        private static OpcUastartup instance = null;
        public static OpcUastartup Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new OpcUastartup();
                }
                return instance;
            }
        }
        //

        private  UAClientHelperAPI m_Server = null;
        private  Subscription m_Subscription;
        private  Subscription m_SubscriptionBlock;
        private  UInt16 m_NameSpaceIndex = 0;

        private  bool status;

        public   bool GetStatus()
        {
            return status;
        }

        public void SetStatus(bool stat)
        {
            status = stat;
        }

        private bool serverConnection = false;

        public bool getServerConnection()
        {
            return serverConnection;
        }

        public bool CheckServerConnection()
        {

            try
            {
                if ( !(m_Server is null ) )
                {
                    serverConnection = true;
                    return true;
                    //if (m_Server.Session.Connected)
                    //{
                    //    return true;
                    //}
                }
                else
                {
                    serverConnection = false;
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
       
        }

        public  UAClientHelperAPI get_m_server()
        {
            try
            {
                return m_Server;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void OPC_close()
        {
            try
            {

                m_Server.Disconnect();
                status = false;
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public void reconnect()
        {
            try
            {
                m_Server.Connect("opc.tcp://192.168.90.39:4840", "none", MessageSecurityMode.SignAndEncrypt, true, "OpcUaClient", "12345678");
                status = true;

                List<string> nodesToRead = new List<string>();
                nodesToRead.Add("ns=0;i=" + Variables.Server_NamespaceArray.ToString());
            }
            catch
            {
                Console.WriteLine("Wrong connections data, check opc address and credentials");
                status = false;
                return;
            }
        }

        public void disconnect()
        {
            // Close the session.
            try
            {
                m_Server.Disconnect();
                Console.WriteLine("OPCAUA  has been disconnected!");
            }
            catch (Exception e)
            {
                //handle Exception here
                throw e;
            }
        }


        public void OPC()
        {
            m_Server = new UAClientHelperAPI();
            m_Server.CertificateValidationNotification += new CertificateValidationEventHandler(m_Server_CertificateEvent);

            try
            {
                m_Server.Connect("opc.tcp://192.168.90.39:4840", "none", MessageSecurityMode.SignAndEncrypt, true, "OpcUaClient", "12345678");
                status = true;

                List<string> nodesToRead = new List<string>();
                nodesToRead.Add("ns=0;i=" + Variables.Server_NamespaceArray.ToString());
            }
            catch
            {
                Console.WriteLine("Wrong connections data, check opc address and credentials");
                status = false;
                return;
            }

        

         
        }
        public void DataGatherer()
        {

        }


        private  void m_Server_CertificateEvent(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            // Accept all certificate -> better ask user
            e.Accept = true;
        }

        private void check_internert_connection()
        {

        }

    }


}