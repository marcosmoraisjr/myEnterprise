<%

Option Explicit

'-------------------------------------------
'---- Generated by the ASP Table Wizard ----
'---- http://www.paulsimmons.com        ----
'-------------------------------------------

Dim iCount
Dim sRowColor
Dim objDB
Dim objRS
Dim sDBName

'TODO: Verify database path...
sDBName = "driver={Microsoft Access Driver (*.mdb)};dbq=L:\mmstec\PROJETOS\Solution Portal\portal\App_Data\PORTAL.mdb"
Set objDB = Server.CreateObject("ADODB.Connection")
objDB.Open sDBName

'TODO: Modify the next line to only return the records you want...
Set objRS = objDB.Execute("select * from FAVORITOS")

Response.Write("<html>")
Response.Write("<head>")
Response.Write("<title>ASP Table Wizard</title>")
Response.Write("</head>")
Response.Write("<body bgcolor=white>")

Response.Write("<h3>ASP Table Wizard</h3>")

If objRS.EOF Then
	Response.Write("<b>No matching records found.</b>")
	objRS.Close
	objDB.Close
	Set objRS = Nothing
	Set objDB = Nothing
	Response.End
End If

Response.Write("<table border=1 cellpadding=2 cellspacing=2>")
Response.Write("<tr bgcolor=silver>")

'COOL TIP: the <filter> tag is used by Excel 97 and later...
'if your users save this file from the browser and open it in XL, XL will
'parse all the table cells into XL ranges and turn on filtering...

Response.Write("<th filter=ALL>Favoritosid</th>")
Response.Write("<th filter=ALL>Favoritosurl</th>")
Response.Write("<th filter=ALL>Favoritosdatacadastro</th>")
Response.Write("<th filter=ALL>Favoritosnome</th>")
Response.Write("</tr>")

Do While Not objRS.EOF
	'this code alternates the color of the table rows...
	iCount = iCount + 1
	If iCount Mod 2 = 0 Then
		sRowColor = "skyblue"
	Else
		sRowColor = "#C4CEE5"
	End If

	Response.Write("<tr bgcolor=" & sRowColor & ">")
	Response.Write("<td align=right>" & objRS("Favoritosid") & "</td>")
	Response.Write("<td>" & objRS("Favoritosurl") & "</td>")
	Response.Write("<td align=right>" & objRS("Favoritosdatacadastro") & "</td>")
	Response.Write("<td>" & objRS("Favoritosnome") & "</td>")
	Response.Write("</tr>")
	objRS.MoveNext
Loop

Response.Write("</table>")
Response.Write("</body>")
Response.Write("</html>")

objRS.Close
objDB.Close
Set objRS = Nothing
Set objDB = Nothing

%>

