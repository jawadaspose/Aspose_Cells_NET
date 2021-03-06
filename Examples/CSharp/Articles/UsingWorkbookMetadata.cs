﻿using System;
using Aspose.Cells;
using Aspose.Cells.Metadata;

namespace Aspose.Cells.Examples.Articles
{
    class UsingWorkbookMetadata
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Open Workbook metadata
            MetadataOptions options = new MetadataOptions(MetadataType.DocumentProperties);
            WorkbookMetadata meta = new WorkbookMetadata(dataDir + "Sample1.xlsx", options);

            // Set some properties
            meta.CustomDocumentProperties.Add("test", "test");

            // Save the metadata info
            meta.Save(dataDir + "Sample2.out.xlsx");

            // Open the workbook
            Workbook w = new Workbook(dataDir+ "Sample2.xlsx");

            // Read document property
            Console.WriteLine(w.CustomDocumentProperties["test"]);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
