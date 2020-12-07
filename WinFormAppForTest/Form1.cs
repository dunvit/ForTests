using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ProtoBuf;

namespace WinFormAppForTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = new List<Pilot>
            {
                new Pilot {Id = Guid.NewGuid(), Age = 27, Name = "Dunkan"},
                new Pilot {Id = Guid.NewGuid(), Age = 22, Name = "Dana"},
                new Pilot {Id = Guid.NewGuid(), Age = 26, Name = "Dezz"}
            };

            //Serializer.Deserialize<IEnumerable<Pilot>>()
            var dataAfterSerialize = ProtobufTools.Serialize(data);

            var stringAfterSerialize = System.Text.Encoding.Default.GetString(dataAfterSerialize);

            var stringAfterDeserialize = ProtobufTools.Deserialize<List<Pilot>>(dataAfterSerialize);

        }

        

    }
}
