using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

public partial class admin_VateImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateCheckCodeImage(CreateCode());
    }
    public string CreateCode()
    {
        string so = "1,2,3,4,5,6,7,8,9,0";
        string[] strArr = so.Split(',');
        string code = "";
        Random rand = new Random();
        for (int i = 0; i < 4; i++)
        {
            code += strArr[rand.Next(0, strArr.Length)];
        }
        Response.Cookies.Add(new HttpCookie("validate", code));
        return code;
    }
    private void CreateCheckCodeImage(string validata)
    {    //若校验码为空,则直接返回    
        if (validata == null || validata.Trim() == String.Empty)
            return;
        //根据校验码的长度确定输出图片的长度    
        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(Convert.ToDecimal(validata.Length * 15)), 20);
        //创建Graphics对象    
        Graphics g = Graphics.FromImage(image);
        try
        {
            //清空图片背景色       
            g.Clear(Color.White);
            //画图片的背景噪音线        
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                //噪音线起点坐标(x1,y1),终点坐标(x2,y2)            
                int x1 = random.Next(image.Width);
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                //用银色线画出噪音线            
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
            }        //输出图片中校验码的字体        
            Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
            //线性渐变画刷        
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Purple, 1.2f, true);
            g.DrawString(validata, font, brush, 2, 2);
            //画图片的前景噪音点        
            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }        //画图片的边框线        
            g.DrawRectangle(new Pen(Color.SaddleBrown), 0, 0, image.Width - 1, image.Height - 1);
            //创建内存流用于输出图片,这里的MemoryStream会在使用后就被Dispose()        
            using (MemoryStream ms = new MemoryStream())
            {            //图片格式指定为png           
                image.Save(ms, ImageFormat.Png);
                //清除缓冲区流中的所有输出            
                Response.ClearContent();
                //输出流的HHT MIME类型设置为"image/png"            
                Response.ContentType = "image/Png";
                //输出的图片的二进制流           
                Response.BinaryWrite(ms.ToArray());
            }
        }
        finally
        {        //释放Bitmap对象和Graphics对象        
            g.Dispose();
            image.Dispose();
        }
    }
}
