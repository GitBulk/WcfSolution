using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client.Proxies
{
    public class ClientBaseProxy<T> : ClientBase<T> where T: class
    {
        public void CleanUp()
        {
            try
            {
                if (base.State != CommunicationState.Faulted)
                {
                    base.Close();
                }
                else
                {
                    base.Abort();
                }
            }
            catch (Exception ex)
            {
                base.Abort();
            }

        }
    }
}
