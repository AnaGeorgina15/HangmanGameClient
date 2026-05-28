using System.ServiceModel;

namespace HangmanGameWPF.Services
{
    internal static class ServiceClientFactory
    {
        public static IUserService CreateUserClient()
        {
            return new ChannelFactory<IUserService>("BasicHttpBinding_IUserService")
                .CreateChannel();
        }

        public static void CloseChannel(object channel)
        {
            var communicationObject = channel as ICommunicationObject;

            if (communicationObject == null)
            {
                return;
            }

            try
            {
                if (communicationObject.State == CommunicationState.Opened)
                {
                    communicationObject.Close();
                }
                else
                {
                    communicationObject.Abort();
                }
            }
            catch
            {
                communicationObject.Abort();
            }
        }
    }
}
