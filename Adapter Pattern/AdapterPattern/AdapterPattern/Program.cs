using AdapterPattern;

String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

IXmlParser<Note> parser = new XmlParser<Note>();
Note note = parser.Parse(someXml);
Console.WriteLine(parser.ConvertToXml(note));

IJsonParser<Note> parser2 = new XmlToJsonAdapter<Note>();
Note note2 = parser2.Parse(someXml);
Console.WriteLine(parser2.ConvertToJson(note));