# NLog
NLog : Flexible &amp; free open-source logging for .NET Download NLog

Different type of log levels in Nlog are : FEWIDT

Fatal	Highest level: important stuff down
Error	For example application crashes / exceptions.
Warn	Incorrect behavior but the application can continue
Info	Normal behavior like mail sent, user updated profile etc.
Debug	Executed queries, user authenticated, session expired
Trace	Begin method X, end method X etc

You can specify format like below  in target tag
layout="${longdate} | ${callsite} | ${level} | ${message}"

which results log like 
2017-03-20 10:48:34.6947 ||FATAL || Client ID : 5|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
2017-03-20 10:48:35.3197 ||ERROR || Client ID : 10|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
2017-03-20 10:48:35.3237 ||WARN || Client ID : 20|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
2017-03-20 10:48:35.3287 ||INFO || Client ID : 25|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
2017-03-20 10:48:35.3357 ||DEBUG || Client ID : 30|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
2017-03-20 10:48:35.3397 ||TRACE || Client ID : 35|| Class : NLogConsole.Program || Follwed By Environment Details || System.Exception: Exception of type 'System.Exception' was thrown.
