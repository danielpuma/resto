function getURLParameters() 
{
	var sURL = window.document.URL.toString();
	
	if (sURL.indexOf("?") > 0)
	{
		var arrParams = sURL.split("?");
			
		var arrURLParams = arrParams[1].split("&");
		
		var arrParamNames = new Array(arrURLParams.length);
		var arrParamValues = new Array(arrURLParams.length);
		
		var i = 0;
		for (i=0;i<arrURLParams.length;i++)
		{
			var sParam =  arrURLParams[i].split("=");
			arrParamNames[i] = sParam[0];
			if (sParam[1] != "")
				arrParamValues[i] = unescape(sParam[1]);
			else
				arrParamValues[i] = "No Value";
		}
		
		for (i=0;i<arrURLParams.length;i++)
		{
			alert(arrParamNames[i]+" = "+ arrParamValues[i]);
		}
	}
	else
	{
		alert("No parameters.");
	}
}

function getURLParametersByName(ParamName) 
{
	var sURL = window.document.URL.toString();
	
	if (sURL.indexOf("?") > 0)
	{
		var arrParams = sURL.split("?");
			
		var arrURLParams = arrParams[1].split("&");
		
		var arrParamNames = new Array(arrURLParams.length);
		var arrParamValues = new Array(arrURLParams.length);
		
		var i = 0;
		for (i=0;i<arrURLParams.length;i++)
		{
			var sParam =  arrURLParams[i].split("=");
			arrParamNames[i] = sParam[0];
			if (sParam[1] != "")
				arrParamValues[i] = unescape(sParam[1]);
			else
				arrParamValues[i] = "";
		}
		
		for (i=0;i<arrURLParams.length;i++)
		{
		    if(arrParamNames[i]==ParamName)
			    return arrParamValues[i];
		}
		return "";
	}
	else
	{
		
	}
}