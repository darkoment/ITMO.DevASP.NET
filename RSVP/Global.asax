﻿<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Код, выполняемый при запуске приложения
        Application["Visitors"] = 0;

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Код, выполняемый при завершении работы приложения

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Код, выполняемый при появлении необработанной ошибки

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Код, выполняемый при запуске нового сеанса
        Application["Visitors"] = long.Parse(Application["Visitors"].ToString()) + 1;
    }

    void Session_End(object sender, EventArgs e)
    {
        // Код, выполняемый при запуске приложения. 
        // Примечание: Событие Session_End вызывается только в том случае, если для режима sessionstate
        // задано значение InProc в файле Web.config. Если для режима сеанса задано значение StateServer 
        // или SQLServer, событие не порождается.

    }

</script>
