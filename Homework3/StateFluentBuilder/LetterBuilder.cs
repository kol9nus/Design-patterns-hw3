using System.Collections.Generic;

namespace Homework3.StateFluentBuilder
{
    public class LetterBuilder
    {
        public LetterBodyBuilder AddRecipient(string recipient)
        {
            return new LetterBodyBuilder(recipient);
        }

        public class LetterBodyBuilder
        {
            private readonly string _recipient;

            public LetterBodyBuilder(string recipient)
            {
                _recipient = recipient;
            }

            public FinalLetterWithoutTopicBuilder AddLetterBody(string body)
            {
                return new FinalLetterWithoutTopicBuilder(_recipient, body);
            }
        }

        public class FinalLetterWithoutTopicBuilder
        {
            private readonly string _recipient;
            private readonly string _body;
            private readonly List<string> _copyRecipients;

            public FinalLetterWithoutTopicBuilder(string recipient, string body)
            {
                _recipient = recipient;
                _body = body;
                _copyRecipients = new List<string>();
            }

            public FinalLetterWithoutTopicBuilder AddCopyRecipient(string recipient)
            {
                _copyRecipients.Add(recipient);
                return this;
            }

            public FinalLetterBuilder AddTopic(string topic)
            {
                return new FinalLetterBuilder(_recipient, _body, _copyRecipients, topic);
            }

            public string Build()
            {
                string result = "";
                result += "Получатель: " + _recipient + "\n";
                if (_copyRecipients.Count != 0)
                {
                    result += "Отправить копию: ";
                    foreach (string recipient in _copyRecipients)
                    {
                        result += recipient + "; ";
                    }
                    result += "\n";
                }
                result += _body;
                return result;
            }
        }

        public class FinalLetterBuilder
        {
            private readonly string _recipient;
            private readonly string _body;
            private readonly List<string> _copyRecipients;
            private readonly string _topic;

            public FinalLetterBuilder(string recipient, string body, List<string> copyRecipients, string topic)
            {
                _recipient = recipient;
                _body = body;
                _copyRecipients = copyRecipients;
                _topic = topic;
            }

            public FinalLetterBuilder AddCopyRecipient(string recipient)
            {
                _copyRecipients.Add(recipient);
                return this;
            }

            public string Build()
            {
                string result = "";
                result += "Получатель: " + _recipient + "\n";
                if (_copyRecipients.Count != 0)
                {
                    result += "Отправить копию: ";
                    foreach (string recipient in _copyRecipients)
                    {
                        result += recipient + "; ";
                    }
                    result += "\n";
                }
                if (!_topic.Equals(""))
                {
                    result += _topic + "\n";
                }

                result += _body;
                return result;
            }
        }

    }
}
