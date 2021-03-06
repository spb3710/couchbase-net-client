namespace Couchbase.Core.Logging
{
    internal interface IRedactor
    {
        /// <summary>
        /// Redact user data like username, statements, etc
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        object UserData(object message);

        /// <summary>
        /// Redact meta data like bucket names, etc
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        object MetaData(object message);

        /// <summary>
        /// Redact system data like hostnames, etc.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        object SystemData(object message);
    }
}
