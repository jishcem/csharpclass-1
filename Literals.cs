using System;
namespace SampleApp
{
	public class Literals
	{
		public Literals()
		{
			var xml = "hi there, how are you" +
				"I am fine." +
				"alskdjald" +
				"as" +
				"dad" +
				"asd" +
				"sad" +
				"as" +
				"s";

            var xmlLiteral = """
          <element attr="content">
            <body>
            </body>
          </element>
""";

			var someLength = 10;


            var json = $$"""
             {
                "summary": "text",
                "length" : {{someLength}},
             };
             """;
        }
	}
}

