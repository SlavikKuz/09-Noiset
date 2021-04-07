﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PdfCreatorLib.Providers
{
    public class TemplateProvider
    {
        private List<DataItem> _inputData;

        public TemplateProvider(List<DataItem> inputData)
        {
            _inputData = inputData;
        }

        public string GetHTMLTemplate()
        {
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>LastName</th>
                                        <th>Age</th>
                                        <th>Gender</th>
                                    </tr>");
            foreach (var emp in _inputData)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", emp.GoogleDescription, emp.AmazonDescription, emp.AzureDescription, emp.Image);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
