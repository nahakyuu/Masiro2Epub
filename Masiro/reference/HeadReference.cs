﻿namespace Masiro.reference
{
    internal class HeadReference
    {
        public static readonly string ContainerXmlHead =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?><container version=\"1.0\" xmlns=\"urn:oasis:names:tc:opendocument:xmlns:container\"><rootfiles><rootfile full-path=\"OEBPS/content.opf\" media-type=\"application/oebps-package+xml\"/></rootfiles></container>";

        public static readonly string ContentXmlHead =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?><package version=\"2.0\" unique-identifier=\"BookId\" xmlns=\"http://www.idpf.org/2007/opf\"><metadata xmlns:dc=\"http://purl.org/dc/elements/1.1/\"><dc:language>zh</dc:language>";

        public static readonly string SectionXmlHead =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\"\r\n\"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><link href=\"../Styles/style.css\" rel=\"stylesheet\" type=\"text/css\"/>";

        public static readonly string StyleCss =
            "body {\r\n    padding: 0%;\r\n    margin-top: 0%;\r\n    margin-bottom: 0%;\r\n    margin-left: 1%;\r\n    margin-right: 1%;\r\n    line-height: 130%;\r\n    text-align: justify;\r\n}\r\nh1 {\r\n    line-height: 130%;\r\n    text-align: center;\r\n    font-weight: bold;\r\n    font-size: xxx-large;\r\n    margin-top: 0.2em;\r\n    margin-bottom: 0.3em;\r\n}\r\nh2 {\r\n    line-height: 130%;\r\n    text-align: center;\r\n    font-weight: bold;\r\n    font-size: x-large;\r\n    margin-top: 0.2em;\r\n    margin-bottom: 0.3em;\r\n}\r\nh2.subtitle {\r\n    font-size: 20px;\r\n}\r\nh3 {\r\n    font-size: large;\r\n    line-height: 130%;\r\n    text-align: center;\r\n    text-indent: 0em;\r\n    font-weight: bold;\r\n    margin-top: 0.2em;\r\n    margin-bottom: 0.2em;\r\n}\r\nh5 {\r\n    font-size: 1.5em;\r\n    text-indent: 0em;\r\n    font-weight: bold;\r\n    text-align: center;\r\n    margin-top: 15px;\r\n    margin-bottom: 10px;\r\n}\r\nh5.inside {\r\n    line-height: 100%\r\n}\r\nh4 {\r\n    font-size: 1.0em;\r\n    text-align: center;\r\n    text-indent: 0em;\r\n    font-weight: bold;\r\n    margin-top: 5px;\r\n    margin-bottom: 7px;\r\n}\r\n.width\r\n{\r\n    width:100%;\r\n}\r\ndiv {\r\n    margin: 0px;\r\n    padding: 0px;\r\n    text-align: justify;\r\n}\r\np {\r\n    text-indent: 2em;\r\n    display: block;\r\n    line-height: 1.3em;\r\n    margin-top: 0.4em;\r\n    margin-bottom: 0.4em;\r\n}\r\n.bb {\r\n    border-style: none solid none solid;\r\n    border-color: #000000;\r\n    border-width: 1px;\r\n}\r\n.biaoti {\r\n    font-size: 1.5em;\r\n    text-indent: 0em;\r\n    font-weight: bold;\r\n    text-align: center;\r\n    margin-top: 0.4em;\r\n    margin-bottom: 0.4em;\r\n}\r\n.biaoti-left {\r\n    font-size: 1.3em;\r\n    text-indent: 0em;\r\n    font-weight: bold;\r\n    margin-top: 0.4em;\r\n    margin-bottom: 0.4em;\r\n}\r\n.caiye {\r\n    text-indent: 0em;\r\n    font-size:1.2em;\r\n    font-weight:bold;\r\n}\r\n.caiye2 {\r\n    text-indent: 0em;\r\n    font-size:1.0em;\r\n    font-weight:bold;\r\n}\r\n.caiye3 {\r\n    text-indent: 0em;\r\n    font-size:0.8em;\r\n}\r\n.contents {\r\n    text-indent: -2em;\r\n    font-size: 1.2em;\r\n    font-weight: bold;\r\n    margin-top: 0.4em;\r\n    margin-bottom: 0.4em;\r\n    margin-left: 3em;\r\n}\r\n.cut-img {\r\n    text-indent: 0em;\r\n    text-align: center;\r\n    margin-top: 50%;\r\n    margin-bottom: 50%;\r\n}\r\n.cut-line {\r\n    text-indent: 0em;\r\n    line-height: 0;\r\n    margin-top: 0.3em;\r\n    margin-bottom: 0.3em;\r\n}\r\n.cover {\r\n    margin: 0;\r\n    padding: 0px;\r\n    text-indent: 0;\r\n    text-align: center;\r\n}\r\n.dash-break {\r\n    word-break:break-all;\r\n    word-wrap:break-word;\r\n}\r\n.illus {\r\n    text-indent: 0;\r\n    text-align: center;\r\n}\r\n.left {\r\n    text-indent: 0em;\r\n    text-align: left;\r\n}\r\n.line-index {\r\n    width: 50%;\r\n    text-align: left;\r\n    margin-left: 1em;\r\n}\r\n.message {\r\n    text-indent: 0em;\r\n    line-height: 120%;\r\n    margin-top: 0.2em;\r\n    margin-bottom: 0.2em;\r\n}\r\n.right {\r\n    text-align: right;\r\n}\r\n.stress {\r\n    font-weight: bold;\r\n    font-size: 1.1em;\r\n    margin-top: 0.3em;\r\n    margin-bottom: 0.3em;\r\n}\r\n.title {\r\n    border-style: ridge groove none none;\r\n    border-color: #4682b4;\r\n    border-width: 6px;\r\n    margin: 12px;\r\n    padding: 8px;\r\n}\r\n.zuozhe {\r\n    font-size:1.2em;\r\n    text-align:right;\r\n    font-weight:bold;\r\n    font-style:italic;\r\n    margin-right: 1em;\r\n}\r\n.postil-b {\r\n    font-size: 0.8em;\r\n    vertical-align: super;\r\n    font-weight: bold;\r\n    color: #6b8e23;\r\n}\r\n.postil-od {\r\n    font-size: 0.9em;\r\n    text-indent: -1em;\r\n    line-height: 120%;\r\n    color: #2f4f4f;\r\n    padding-left: 1em;\r\n    margin: 0.6em 5% 0.6em 1.5em;\r\n    border-style: dotted solid dotted none;\r\n    border-color: #2f4f4f;\r\n    border-width: 1px;\r\n    border-right-width: 0.5em;\r\n}\r\n.noindent {\r\n    text-indent: 0em;\r\n}\r\n.nounder\r\n{\r\n    text-decoration: none;\r\n}\r\n.center\r\n{\r\n    text-indent:0em;\r\n    text-align: center;\r\n    margin-top: 5px;\r\n    margin-bottom: 5px;\r\n}\r\n.bold {\r\n    font-weight: bold;\r\n}\r\n.small {\r\n    font-size: 0.8em;\r\n}\r\n.english {\r\n    font-size: 0.5em;\r\n}\r\n\r\n.cut-text {\r\n    font-size: 1.2em;\r\n    font-weight: bold;\r\n    text-indent: 0em;\r\n    text-align: center;\r\n    margin-top: 50%;\r\n    margin-bottom: 0%;\r\n}\r\n\r\n.cut-text-right {\r\n    font-size: 0.9em;\r\n\r\n    text-indent: 0em;\r\n    text-align: right;\r\n\r\n}\r\ntable.center {\r\n    margin-left:auto;\r\n    margin-right:auto;\r\n    text-align:left;\r\n}\r\n.more-indent {\r\n    text-indent: 4em;\r\n}\r\nspan.frame1 {\r\n    font-size: 0.9em;\r\n    border-style: solid;\r\n    border-width: 1px;\r\n    background-color: #f7f3f2;\r\n}\r\n.middle {\r\n    text-align: center;\r\n    text-indent: 0em;\r\n}\r\n.float {\r\n    float: right;\r\n}\r\n\r\n/*文字颜色*/\r\n.color1 {\r\n    color: #ffffff;\r\n}\r\n.color2 {\r\n    color: #F44475;\r\n}\r\n.color3 {\r\n    color: #89B238;\r\n}\r\n.color4 {\r\n    color: #F85D24;\r\n}\r\n.color5 {\r\n    color: #ffb6c1;\r\n}\r\n.color6 {\r\n    color: #3a0088;\r\n}\r\n.color7 {\r\n    color: #5523CC;\r\n}\r\n.color8 {\r\n    color: #00bbff;\r\n}\r\n.color9 {\r\n    color: #000;\r\n}\r\n.color10 {\r\n    color: #2B0D4D;\r\n}\r\n.color11 {\r\n    color: #f0f0f0;\r\n}\r\n";

        public static readonly string TocXmlHead =
            "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<!DOCTYPE ncx PUBLIC \"-//NISO//DTD ncx 2005-1//EN\"\r\n        \"http://www.daisy.org/z3986/2005/ncx-2005-1.dtd\"><ncx version=\"2005-1\" xmlns=\"http://www.daisy.org/z3986/2005/ncx/\">\r\n    <head>\r\n        <meta content=\"urn:uuid:f550de6c-6d94-4503-a026-669356145316\" name=\"dtb:uid\"/>\r\n        <meta content=\"1\" name=\"dtb:depth\"/>\r\n        <meta content=\"0\" name=\"dtb:totalPageCount\"/>\r\n        <meta content=\"0\" name=\"dtb:maxPageNumber\"/>\r\n    </head>\r\n    <docTitle>";
    }
}