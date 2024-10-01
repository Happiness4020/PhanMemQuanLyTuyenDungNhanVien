using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public partial class frmSaoLuuPhucHoi : Form
    {
        public frmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void btn_Saoluu_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sao lưu dữ liệu không?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                  
                        string connectionString = "mongodb://localhost:27017";
                        MongoClient client = new MongoClient(connectionString);
                        IMongoDatabase database = client.GetDatabase("QLTuyenDungNhanVien"); 
                        IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("vitrituyendung"); 

                  
                        var projection = Builders<BsonDocument>.Projection.Exclude("_id");
                        var documents = collection.Find(new BsonDocument()).Project(projection).ToList();

                  
                        string filePath = "saoluu.txt"; 
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            foreach (var document in documents)
                            {
                                writer.WriteLine(document.ToJson());
                            }
                        }

                        MessageBox.Show("Sao lưu dữ liệu thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sao lưu dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Phuchoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn phục hồi dữ liệu từ sao lưu trước đó không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string filePath = "saoluu.txt"; 
                    string[] lines = File.ReadAllLines(filePath);

                    // Kiểm tra xem tệp có dữ liệu không
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Tệp saoluu.txt trống. Chưa từng có sao lưu trước đó.");
                        return;
                    }

                    // Kết nối đến MongoDB
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    IMongoDatabase database = client.GetDatabase("QLTuyenDungNhanVien"); 
                    IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("vitrituyendung");

                    // Xóa toàn bộ dữ liệu từ collection tuyendung
                    collection.DeleteMany(FilterDefinition<BsonDocument>.Empty);

                    // Insert dữ liệu từ tệp saoluu.txt vào collection tuyendung
                    foreach (string line in lines)
                    {
                        var document = BsonDocument.Parse(line);
                        collection.InsertOne(document);
                    }

                    MessageBox.Show("Phục hồi dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi phục hồi dữ liệu: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
