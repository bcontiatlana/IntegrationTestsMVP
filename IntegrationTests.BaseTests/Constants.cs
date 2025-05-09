namespace IntegrationTests.Base
{
    public static class Constants
    {
        public const string QUEUE_DOMAIN = "test.queue-it.net";
        public const string CUSTOMER_ID = "queueitknownusertst";
        public const string CUSTOMER_SECRET_KEY = "954656b7-bcfa-4de5-9c82-ff3805edd953737070fd-2f5d-4a11-b5ac-5c23e1b097b1";
        public const string CUSTOMER_QITCONNECTORHASHTST_SECRET_KEY = "4f09c8ad-a10c-4ccc-89c0-1f9099ba80a9b2f5ca2d-7fdc-4b64-835c-d0724b5dfa2c";
        public const string EVENTID_EVENT1 = "event1";
        public const string EVENTID_EVENT2 = "event2";
        public const string EVENTID_PAUSED = "paused";
        public const string EVENTID_FUTURE = "future";
        public const string EVENTID_DISABLED = "disabled";
        public const string EVENTID_SAFETYNET = "safetynet";
        public const string EVENTID_ALWAYSSAFETYNET = "alwayssafetynet";
        public const string COOKIENAME_QUEUEITDEBUG = "queueitdebug";

        public const string EVENT_WR01 = "wr01";
        public const string CUSTOMER_QITCONNECTORHASHTST_ID = "qitconnectorhashtst";

        public static class QueueItTokens
        {
            public static class Debug
            {
                public const string Valid = "queueittoken=ts_2213263992~e_d~ce_False~q_00000000-0000-0000-0000-000000000000~rt_debug~h_18e4bf28af9d0bfd1942406b9c71cdf1002f4f9ab646ff476474b27587a321fc";
                public const string Modified = "queueittoken=ts_2213263992~e_d~ce_False~q_00000000-0000-0000-0000-000000000000~rt_debug~h_18e4bf28af9d0bfd1942406b9c71cdf1002f4f9ab646ff476474b27587a321fc__";
                public const string Expired = "queueittoken=ts_1550576114~e_d~ce_False~q_00000000-0000-0000-0000-000000000000~rt_debug~h_b974ade2767cefbf0490c9ccc8193efda12cd80f3c6254394bca8b38bc679389";
            }

            public const string EXPIRED = "queueittoken=e_event1~q_a55744cf-4f1f-4e7a-8f7c-6c87aa5f2ae2~ts_1517404943~ce_true~rt_queue~h_78121c1506e9fe1597cd114379816a2a258895d5a91fc9dcca7a59c76dbb4f54";
            public const string CUTOFF = "queueittoken=e_event1~q_a55744cf-4f1f-4e7a-8f7c-6c87aa5f2ae2~ts";
            public const string KEYSONLY = "queueittoken=e~q~ts~ce~rt~h";
            public const string GIBBERISH = "queueittoken=junk~ww~*[&";   // There was ^ char in the string which was breaking ruby request.
        }

        public static class ActionNames
        {
            public const string EVENT1_QUEUE_ACTION = "event1%20queue%20action%20%28ticketania%29";
            public const string EVENT1_QUEUE_ACTION_COOKIE = "event1 queue action (ticketania)";
            public const string DISABLED_QUEUE_ACTION = "disabled%20queue%20action%20%28ticketania%29";

            public const string EVENT1_QUEUE_ACTION_CDN = "event1%20queue%20action%20%28akamai%20cdn%29";
            public const string EVENT1_QUEUE_ACTION_COOKIE_CDN = "event1 queue action (akamai cdn)";
            public const string DISABLED_QUEUE_ACTION_CDN = "disabled%20queue%20action%20%28akamai%20cdn%29";
        }

        public const string QUEUE_JS_PATH = "?queue-js-event1";
        public const string QUEUE_PATH = "?queue-event1";
        public const string CANCEL_PATH = "?cancel-event1";
        public const string IGNORE_PATH_1 = "?ignore-queue-event1";
        public const string IGNORE_PATH_2 = "?ignore-this-queue-event1";
        public const string IGNORE_PATH_3 = "?ignore-that-queue-event1";
        public const string IDLE_PATH = "?idle-future";
        public const string DISABLED_PATH = "?queue-disabled";
        public const string DISABLED_NOTEXTEND_PATH = "?queue-disabled-notextendcookie-nodomain";
        public const string SAFETYNET_PATH = "?queue-safetynet-nodomain";
        public const string ALWAYSSAFETYNET_PATH = "?queue-alwayssafetynet";

        public const string LOCAL_QUEUE_JS_PATH = "?queue-js-event1-nodomain";
        public const string LOCAL_QUEUE_PATH = "?queue-event1-nodomain";
        public const string LOCAL_CANCEL_PATH = "?cancel-event1-nodomain";
        public const string LOCAL_IGNORE_PATH_1 = "?ignore-queue-event1-nodomain";
        public const string LOCAL_IGNORE_PATH_2 = "?ignore-this-queue-event1-nodomain";
        public const string LOCAL_IGNORE_PATH_3 = "?ignore-that-queue-event1-nodomain";
        public const string LOCAL_IDLE_PATH = "?idle-future-nodomain";
        public const string LOCAL_DISABLED_PATH = "?queue-disabled-nodomain";

        public const string PROTECTED_PAGE_1_PATH = "?protected-page-1";
        public const string PROTECTED_PAGE_2_PATH = "?protected-page-2";
        public const string PAGE_PROTECTED_BY_PAUSED_WR_PATH = "?page-protected-by-paused-waiting-room";
        public const string PAGE_TRIGGERING_CANCEL_MULTIPLE_ACTION_PATH = "?page-triggering-cancel-multiple-action";

        public static string QueueItAcceptedCookieNamePrefix => "QueueITAccepted-SDFrts345E-V3_";

        public static string GetQueueItAcceptedCookieName(string eventId) => $"{QueueItAcceptedCookieNamePrefix}{eventId}";
    }
}
