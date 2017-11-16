﻿using Android.App;
using Android.Widget;
using Android.OS;

using System.Net.Http;
using System.IO;
using Android.Graphics;


using System.Threading.Tasks;



namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        ImageView view1;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            Button algorithm1 = FindViewById<Button>(Resource.Id.button1);

            Stream stream = null;
            Bitmap bmp1;
            HttpClient client = new HttpClient();




            stream = client.GetStreamAsync("https://i.imgur.com/OVXxVoA.jpg").Result;


            view1 = FindViewById<ImageView>(Resource.Id.imageView1);


            //Task<HttpResponseMessage> resp = client.PostAsync("http://70.173.104.68:81/thisisanextremelylongurljusttotestsomestuffoutmaily_thelengthlimit_of_a_url_sent_from_a_phone.", null);
            BitmapFactory.Options o = new BitmapFactory.Options();
            o.InMutable = false;
            
            bmp1 = BitmapFactory.DecodeStream(stream, new Rect(), o);
            



            view1.SetImageBitmap(bmp1);


            


            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            algorithm1.Click += delegate
            {
                bmp1.UnlockPixels();
                

                for (int i = 0; i < bmp1.Width; i++)
                {

                    for (int j = 0; j < bmp1.Height; j++)
                    {
                        bmp1.SetPixel(i, j,new Color(23 ));
                    }
                }


//                bmp1 = (Bitmap)BitmapFactory.FromArray<int[]>(datum);
                bmp1.LockPixels();
                view1.SetImageBitmap(bmp1);
            };

        }
    }
}















/*
 * 


namespace App1
{
    public class activity2 : Activity
    {

    }



    [Activity(Label = "App1", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        TextView txtv1;
        TextView txtv2;
        Button b2;

  



        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //SetContentView(Resource.Layout.layout1);


            HttpClient client = new HttpClient();
            PlotView view = FindViewById<PlotView>(Resource.Id.plot_view);
            //view = FindViewById<PlotView>(Resource.Id.plotView1);



            //init UI 
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            txtv1 = FindViewById<TextView>(Resource.Id.textView1);
            txtv2 = FindViewById<TextView>(Resource.Id.textView2);
            b2 = FindViewById<Button>(Resource.Id.button1);
            



            button.Click += Button_Click;


            //variables
            Stream stream = null;
            Bitmap bmp1;
            JsonValue value = JsonValue.Parse(
                       "{" +
                               "\"Library\" : \"System.Json for .NET\"," +
                               "\"Author\" : { " +
                                            "\"Name\" : \"Bourassi Mohamed\"," +
                                            "\"Age\" : 24," +
                                            "\"Blog\" : \"bourassi_med89@yahoo\"" +
                             "}," +
                               "\"Date\" : \"31/07/2013\"," +
                               "\"Tags\" : [\"Json\",\"C#\",\".NET\"]" +
                               "}"

                    );

            /*
                        "{" +
                                          "\"Library\" : \"System.Json for .NET\"," +
                                          "\"Author\" : { " +
                                                       "\"Name\" : \"Bourassi Mohamed\"," +
                                                       "\"Age\" : 24," +
                                                       "\"Blog\" : \"bourassi_med89@yahoo\"" +
                                        "}," +
                                          "\"Date\" : \"31/07/2013\"," +
                                          "\"Tags\" : [\"Json\",\"C#\",\".NET\"]" +
                                          "}"


                  


            if (value.ContainsKey("Library"))
            {
                txtv1.Text = "field found ";

            }
     
       


            //runnable code 



            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            b2.Click += B2_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
{
    //SetContentView(Resource.Layout.layout1);
    var intent = new Intent(this, typeof(App1.Resources.layout.Activity1));
    //intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
    StartActivity(intent);
}

private void B2_Click(object sender, System.EventArgs e)
{
    txtv1.Text += " moar";
}
    }
}



/*
 * using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Systems;
using System.Threading.Tasks;
using System.Threading;
using Android.Net.Http;
using Android.Webkit;
using Xamarin.Android.Net;
using System.Net.Http;
using System.Web;
using System.Web.Util;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
namespace workhere
{
    [Activity(Label = "workhere", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        Button button;
        EditText txt1;
        TextView txt2;
        ImageView imgv1;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.button1);
            txt1 = FindViewById<EditText>(Resource.Id.editText1);
            txt2 = FindViewById<TextView>(Resource.Id.textView1);
            imgv1 = FindViewById<ImageView>(Resource.Id.imageView1);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); }; this is stupid and annoying.  
            txt1.TextChanged += Txt1_TextChanged;




            HttpClient client = new HttpClient();
            HttpMethod mtd = new HttpMethod("methodlol");
            HttpContent cont;
            WebClient client2 = new WebClient();
            /*
             *             byte[] response = client2.UploadValues("http://70.173.104.68:81/uploadstuff/upload.php",
                            new System.Collections.Specialized.NameValueCollection()
                        {

                               { "fileToUpload","filename" }
                                ,{"fileToUpload",  "submitnamelol"}

                        });
                        

System.Collections.Generic.IEnumerable<KeyValuePair<string, string>> quarry =
       new List<KeyValuePair<string, string>>()
   {

                                           new KeyValuePair<string, string>( "leshay~~  ","filename" ),
                                           new KeyValuePair<string, string>( "fileToUpload",  "submitnamelol")

   };

HttpContent httpcont1 = new System.Net.Http.FormUrlEncodedContent(quarry);

//the url is long just so we can test the max length that can be sent.  otherwise this is a blank post method.  
Task<HttpResponseMessage> resp = client.PostAsync("http://70.173.104.68:81/thisisanextremelylongurljusttotestsomestuffoutmaily_thelengthlimit_of_a_url_sent_from_a_phone.", null);
resp.Wait(5000);
            HttpResponseMessage response123 = null;
HttpContent content123 = null;
            if (resp.IsCompleted)
            {
                response123 = resp.Result;
                content123 = response123.Content;
            }




            //   Task<string> getStringTask = client.GetStringAsync("http://70.173.104.68:81/abc.php");
            // txt2.Text = getStringTask.Result;
            // Task<HttpResponseMessage> type = client.GetAsync("http://leurda.mooo.com/abc.php");

            Task<System.IO.Stream> imagemaybe = client.GetStreamAsync("http://i.imgur.com/nZslo1k.jpg");

System.IO.Stream imgurImg = imagemaybe.Result;

Android.Graphics.Bitmap bm;
bm = Android.Graphics.BitmapFactory.DecodeStream(imgurImg);

            //   HttpResponseMessage message = type.Result;
            // HttpContent cont = message.Content;



            imgv1.SetImageBitmap(bm);
            if (content123 != null)
            {
                txt2.Text = content123.ReadAsStringAsync().Result;
            }


        }

        private void Txt1_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
{
    if (txt1.Text.Contains("thot"))
    {
        //  txt1.Text = "gtfo pls";
    }
    // throw new NotImplementedException();
}


        /*
         *         public string ExecutePostRequest(
          Uri url,
          Dictionary<string, string> postData,
          FileInfo fileToUpload,
          string fileMimeType,
          string fileFormKey
        )
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url.AbsoluteUri);
                    request.Method = "POST";
                    request.KeepAlive = true;

                    string boundary = CreateFormDataBoundary();
                    request.ContentType = "multipart/form-data; boundary=" + boundary;
                    request.AllowAutoRedirect = true;
                    request.

                    Stream requestStream = request.GetRequestStream();
                    postData.WriteMultipartFormData(requestStream, boundary);
                    if (fileToUpload != null)
                    {
                        fileToUpload.WriteMultipartFormData(requestStream, boundary, fileMimeType, fileFormKey);
                    }
                    byte[] endBytes = System.Text.Encoding.UTF8.GetBytes("--" + boundary + "--");
                    requestStream.Write(endBytes, 0, endBytes.Length);
                    requestStream.Close();
                    using (WebResponse response = request.GetResponse())
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    };


                }

            }
            
    }
}

*/

