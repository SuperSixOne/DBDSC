using Microsoft.VisualStudio.TestTools.UnitTesting;
using M3.DBDSC.Common.Contracts;
using Newtonsoft.Json;

namespace M3.DBDSC.Common.Tests
{
    [TestClass]
    public class ContractTests
    {
        Schema _TestSchema;

        [TestInitialize]
        public void InitTests()
        {
            _TestSchema = new Schema();

            // Tables
            Table firstTable = new Table();
            firstTable.Name = "TestTable1";
            firstTable.Columns.Add(new Column() { Name = "ColA", Type = "Varchar" });
            firstTable.Columns.Add(new Column() { Name = "ColB", Type = "Varchar" });
            firstTable.Index.Add(new Index() { Name="IndexA" });
            firstTable.Index.Add(new Index() { Name = "IndexB" });
            firstTable.Index.Add(new Index() { Name = "IndexC" });

            Table secondTable = new Table();
            secondTable.Name = "TestTable1";
            secondTable.Columns.Add(new Column() { Name = "ColA", Type = "Varchar" });
            secondTable.Columns.Add(new Column() { Name = "ColB", Type = "Varchar" });
            secondTable.Index.Add(new Index() { Name = "IndexA" });
            secondTable.Index.Add(new Index() { Name = "IndexB" });
            secondTable.Index.Add(new Index() { Name = "IndexC" });

            _TestSchema.Tables.Add(firstTable);
            _TestSchema.Tables.Add(secondTable);

            // Views
            View view = new View();

            _TestSchema.Views.Add(view);
        }

        [TestMethod]
        public void SerializeJig()
        {
            var schemaString = JsonConvert.SerializeObject(_TestSchema);
        }
    }
}
