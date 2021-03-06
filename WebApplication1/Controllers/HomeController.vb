﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Task() As ActionResult
        ViewData("Message") = "Your task page."

        Return View()
    End Function

    Function FlowChart() As ActionResult
        ViewData("Message") = "Flow Chart."

        Return View()
    End Function
End Class
