/*
 * YtelAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities;
using YtelAPI.Standard.Http.Request;
using YtelAPI.Standard.Http.Response;
using YtelAPI.Standard.Http.Client;
using YtelAPI.Standard.Exceptions;

namespace YtelAPI.Standard.Controllers
{
    public partial class EmailController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EmailController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EmailController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EmailController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Remove an email from the invalid email list.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the invalid email list.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailDeleteinvalidemail(string email)
        {
            Task<string> t = CreateEmailDeleteinvalidemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an email from the invalid email list.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the invalid email list.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailDeleteinvalidemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deleteinvalidemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of emails that have been blocked.
        /// </summary>
        /// <param name="Models.CreateEmailListblockemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailListblockemail(Models.CreateEmailListblockemailInput input)
        {
            Task<string> t = CreateEmailListblockemailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of emails that have been blocked.
        /// </summary>
        /// <param name="Models.CreateEmailListblockemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailListblockemailAsync(Models.CreateEmailListblockemailInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listblockemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Offset", input.Offset ),
                new KeyValuePair<string, object>( "Limit", input.Limit )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of emails that are on the spam list.
        /// </summary>
        /// <param name="Models.CreateEmailListspamemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailListspamemail(Models.CreateEmailListspamemailInput input)
        {
            Task<string> t = CreateEmailListspamemailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of emails that are on the spam list.
        /// </summary>
        /// <param name="Models.CreateEmailListspamemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailListspamemailAsync(Models.CreateEmailListspamemailInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listspamemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Offset", input.Offset ),
                new KeyValuePair<string, object>( "Limit", input.Limit )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of emails that have bounced.
        /// </summary>
        /// <param name="Models.CreateEmailListbounceemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailListbounceemail(Models.CreateEmailListbounceemailInput input)
        {
            Task<string> t = CreateEmailListbounceemailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of emails that have bounced.
        /// </summary>
        /// <param name="Models.CreateEmailListbounceemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailListbounceemailAsync(Models.CreateEmailListbounceemailInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listbounceemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Offset", input.Offset ),
                new KeyValuePair<string, object>( "Limit", input.Limit )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Remove an email address from the bounced list.
        /// </summary>
        /// <param name="email">Required parameter: The email address to be remove from the bounced email list.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailDeletebouncesemail(string email)
        {
            Task<string> t = CreateEmailDeletebouncesemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an email address from the bounced list.
        /// </summary>
        /// <param name="email">Required parameter: The email address to be remove from the bounced email list.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailDeletebouncesemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deletebouncesemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of invalid email addresses.
        /// </summary>
        /// <param name="Models.CreateEmailListinvalidemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailListinvalidemail(Models.CreateEmailListinvalidemailInput input)
        {
            Task<string> t = CreateEmailListinvalidemailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of invalid email addresses.
        /// </summary>
        /// <param name="Models.CreateEmailListinvalidemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailListinvalidemailAsync(Models.CreateEmailListinvalidemailInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listinvalidemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Offset", input.Offset ),
                new KeyValuePair<string, object>( "Limit", input.Limit )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of email addresses from the unsubscribe list.
        /// </summary>
        /// <param name="Models.CreateEmailListunsubscribedemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailListunsubscribedemail(Models.CreateEmailListunsubscribedemailInput input)
        {
            Task<string> t = CreateEmailListunsubscribedemailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of email addresses from the unsubscribe list.
        /// </summary>
        /// <param name="Models.CreateEmailListunsubscribedemailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailListunsubscribedemailAsync(Models.CreateEmailListunsubscribedemailInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listunsubscribedemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Offset", input.Offset ),
                new KeyValuePair<string, object>( "Limit", input.Limit )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Remove an email address from the list of unsubscribed emails.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the unsubscribe list.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailDeleteunsubscribedemail(string email)
        {
            Task<string> t = CreateEmailDeleteunsubscribedemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an email address from the list of unsubscribed emails.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the unsubscribe list.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailDeleteunsubscribedemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deleteunsubscribedemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Add an email to the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be added to the unsubscribe list</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailAddunsubscribesemail(string email)
        {
            Task<string> t = CreateEmailAddunsubscribesemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add an email to the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be added to the unsubscribe list</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailAddunsubscribesemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/addunsubscribesemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Remove an email from blocked emails list.
        /// </summary>
        /// <param name="email">Required parameter: The email address to be remove from the blocked list.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailDeleteblocksemail(string email)
        {
            Task<string> t = CreateEmailDeleteblocksemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an email from blocked emails list.
        /// </summary>
        /// <param name="email">Required parameter: The email address to be remove from the blocked list.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailDeleteblocksemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deleteblocksemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Remove an email from the spam email list.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the spam list.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailDeletespamemail(string email)
        {
            Task<string> t = CreateEmailDeletespamemailAsync(email);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an email from the spam email list.
        /// </summary>
        /// <param name="email">Required parameter: A valid email address that is to be remove from the spam list.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailDeletespamemailAsync(string email)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deletespamemail.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Email", email )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Create and submit an email message to one or more email addresses.
        /// </summary>
        /// <param name="Models.CreateEmailSendemailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateEmailSendemails(Models.CreateEmailSendemailsInput input)
        {
            Task<string> t = CreateEmailSendemailsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create and submit an email message to one or more email addresses.
        /// </summary>
        /// <param name="Models.CreateEmailSendemailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateEmailSendemailsAsync(Models.CreateEmailSendemailsInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/sendemails.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "Type", Models.TypeEnumHelper.ToValue(input.Type) ),
                new KeyValuePair<string, object>( "Subject", input.Subject ),
                new KeyValuePair<string, object>( "Message", input.Message ),
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "Cc", input.Cc ),
                new KeyValuePair<string, object>( "Bcc", input.Bcc ),
                new KeyValuePair<string, object>( "Attachment", input.Attachment )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 