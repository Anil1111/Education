﻿namespace _000_AboutXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // eXtensible Markup Language
            //Стандарты XML
            //https://www.w3.org/standards/xml/
            /*
             Любая XML должна "строить дерево". Деперья растят при помощи паттерна композит.

            SOAP - Simple Object Access Protocol базируется на XML. SOAP - это протокол прикладного уровня(самого высокого).
            Есть так же транспортный уровень и т.д

             Текстовый формат, предназначенный для хранения структурированных данных для обмена
             информацией между программами, а так же ДЛЯ СОЗДАНИЯ НА ЕГО ОСНОВЕ
             БОЛЕЕ СПЕЦИАЛИЗИРОВАННЫХ ЯЗЫКОВ РАЗМЕТКИ - XAML - eXtensible Application Markup Language - используется в WPF.
             //Когда добавляешь кнопку - добавляется элемент в XAML.
             ссылка на проект C:\project\Education\HttpAsyncAwait\Calp2\MainWindow.xaml

            <Button Content="+" 
                    HorizontalAlignment="Left" 
                    Margin="402,67,0,0" 
                    VerticalAlignment="Top" 
                    Width="39" 
                    Height="26" 
                    RenderTransformOrigin="0.51,-0.963" 
                    Click="Button_Click"/>
            
            Button - это ничто иное, как класс! Система читает XAML файл, и создает экзампляр класса Button, а вот
            Content, HorizontalAlignment, Margin, VerticalAlignment, Width, Height, RenderTransformOrigin, Click - ЭТО СВОЙСТВА.
            Т.Е имя тега(Button) - это АНАЛОГ КЛАССА, а аттрибуты Content, HorizontalAlignment, Margin и т.д - АНАЛОГ СВОЙСТВ КЛАССА.
            И есть система, которая читает разметку(XAML) и пишет настоящий код , используя рефлексию.

            В программировании есть 2 подхода: ИМПЕРАТИВНЫЙ - когда мы сами пишем что-то , создаем экземпляры классов,
            а есть еще ДЕКЛРАТИВНЫЙ - это когда мы пишем разметку, а код создает другая программа.
             
            Многие юнные программисты хотят создать базу данных, используя XML. Но если мы заглянем "под микроскопом" в МsSQL, то
            увидим, что там испольуется всевдо язык, не такой как XML. Там колонки разделяются МАЛЕНЬКИМИ символами, например || , ЧТОБЫ
            УМЕНЬШИТЬ РАЗМЕР БАЗЫ ДАННЫХ.

            XML удобный для того, чтобы его читали ЛЮДИ и разрабатывался для того, чтобы с ним работала не только машина, НО И ЧЕЛОВЕК.
            

            Структура XML документа:
            1. Объявление XML - первая строка документа, в которой указывается ВЕРСИЯ, КОДИРОВКА ТЕКСТА, ДРУГИЕ ЗАВИСИМОСТИ.
            2. Корневой элемент - является основным телом документа, у каждого документа может быть только один корневой элемент.
            3. Теги - вложенные элементы документа, могут иметь аттрибуты и содержимое
            4. Комментарии - текст, размещеный в теге.

              <?xml varsion="1.0" encoding="iso-8859-1"?>
              <library name="PL" content="Tech">  - корневой элемент документа
                   <book>
                         <title fontsize="8">CLR via C#</title>
                         <price currency="$">11.99</price>
                   </book>
                   <!--This is a comment>
               </library>

             */
        }
    }
}
