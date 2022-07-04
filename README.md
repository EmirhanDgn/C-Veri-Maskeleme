# C# Veri Maskeleme


C# Form Uygulaması ile TextBox İçerisindeki Verinin Belirli Bölümlerini Maskelemeye Yarayan Program

Textbox üzerine girmiş olduğunuz 11 haneli değerin ilk üç hanesi ve son üç hanesi dışında kalanları "X" ile göstererek gizlemektedir. 
Bu kod fonksiyon ile tutulmaktadır. Bu sayede fonksiyon tanımlaması ile dıişarıya karşı TC Kimlik numarasını maskeleyerek yayınlayabilmekteyiz.

Visual Studio 2022

.NET Framework 4.5 (Minimum 4.0) & .NET Core 3.1 & 

<h2>Uygulama Kullanım Resimleri</h2>



  ![tc maskele](https://user-images.githubusercontent.com/76941464/165316892-bbf79726-1f3f-4eb4-9add-66c314b8b2bf.png)

![tc maskele 2](https://user-images.githubusercontent.com/76941464/165316904-4b07dcfd-d7d0-47d2-89c2-c0b2946d8f3a.png)


<h2>Function Kodu</h2>

<pre>
        string Mask(string textvalue, bool check)
        {
            if (check)
            {
                var first = textvalue.Substring(0, 2);
                var last = textvalue.Substring(textvalue.Length - 2, 2);
                var mask = new string('*', textvalue.Length - first.Length - last.Length);
                var masked = string.Concat(first, mask, last);
                return masked.ToString();
            }
            else
            {
                return textvalue;
            }

        }

</pre>
