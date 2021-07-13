req.Query = query;
QueryExpressionToFetchXmlResponse resp = (QueryExpressionToFetchXmlResponse)service.Execute(req);

//work with newly formed fetch string
string myfetch = resp.FetchXml;
