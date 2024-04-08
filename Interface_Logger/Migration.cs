namespace Interface_Logger
{

    public partial class Migration
    {

        private readonly ILogger _logger;

        public Migration(ILogger logger)
        {
            _logger = logger;
        }

        public void migration()
        {
            _logger.LogError("Migration is started:" + DateTime.Now);
            _logger.LogInfo("Migration is Finished:" + DateTime.Now);


        }
    }

}
