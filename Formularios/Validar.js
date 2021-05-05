//-- Limpar Campo
function Limpar(campo)
				{
				document.all(campo).value="";
				return;
				}	

//-- Provocar Evento Click
function Clicar(campo)
				{
				document.all(campo).click();
				return;
				}


//-- Troca tecla Enter por Tab
function onKeyDownTab()
			{
				var e = window.event;
				if (e.keyCode == 13) // Enter
				{
					e.keyCode = 9;   // Tab
				}
				return e;
			}
			
			
//
//	function KDown() 
//{
//	var ctrl=window.event.ctrlKey;
//	var shift=window.event.shiftKey;
//	var alt=window.event.altKey;
//	var tecla=window.event.keyCode; 
//	if (ctrl tecla==65);
//	if (alt tecla==53 );
//	if (ctrl && alt && shift );
//}
//
			
//-- Troca tecla Tab por Enter
function onKeyDownEnter()
			{
				var e = window.event;
				if (e.keyCode == 9) // Tab
				{
					e.keyCode = 13; // Enter
				}
				return e;
			}

//-- Confirma Mensagem
function confirmaMensagem(a) 
				{ 
				if (confirm(a)==true) 
				return true; 
				else 
				return false;  }
				
//-- Converte Valor em String para Float				
function Converte_Valor(vlr) 
            {
            var vRet = "0";
            vlr = vlr.replace(/[a-zA-Z\!\@\#\$\%\^\&amp;\*\(\)\_\+\=\{\}\|\[\]\\\:\"\;'\&lt;\&gt;\?\/\~\`]/g,"");
                                 
            if (vlr != "") 
               {
                if (vlr.length > 3)
                   {
                    var inteiro = vlr.substr(0,vlr.length - 3);
                    var centavos = vlr.substr(vlr.length - 3);
                    vRet = inteiro.replace(".", "") + centavos.replace(",",".");
                    }
                else
                    { 
                    vRet = vlr.replace(",", ".");
                    }
               }
               return parseFloat(vRet);
			
			}
				

//-- Formata valor no modelo "000.000,00"	
function Formata_Valor(valor) 
{ 
	var inteiro  = valor.substring(0,valor.indexOf('.'))
	var centavos = valor.substring(valor.indexOf('.') + 1)		
	for (var i = 0; i < Math.floor((inteiro.length-(1+i))/3); i++) 
		inteiro = inteiro.substring(0,inteiro.length-(4*i+3))+"."+inteiro.substring(inteiro.length-(4*i+3)); 
    inteiro = inteiro.replace("-.","-");
	return (inteiro + "," + centavos); 
} 


//-- Replicar Caracteres
function replicate(str,qte) 
{
     var ret='';
     for (i=0; i < qte; i++)
         ret += str;
     return ret;
} 
 

//-- Efetua validação de CPF
function verificarCPF(xCPF)
{
		var i; 
		var c = xCPF.value;
		s = c;
		var c = s.substr(0,9); 
		var dv = s.substr(9,2); 
		var d1 = 0; 
		if (s !=""){
		
		for (i = 0; i < 9; i++) 
			{ 
			d1 += c.charAt(i)*(10-i); 
			} 
		if (d1 == 0){ 
			alert("CPF Invalido")
			xCPF.value="";
			xCPF.focus();
			return false;	
		} 
		d1 = 11 - (d1 % 11); 
		if (d1 > 9) d1 = 0; 
		if (dv.charAt(0) != d1) 
			{ 
			alert("CPF Invalido") 
			xCPF.value="";
			xCPF.focus();
			return false;	
			} 

		d1 *= 2; 
		for (i = 0; i < 9; i++) 
			{ 
			d1 += c.charAt(i)*(11-i); 
			} 
		d1 = 11 - (d1 % 11); 
		if (d1 > 9) d1 = 0; 
		if (dv.charAt(1) != d1) 
			{ 
			alert("CPF Invalido") 
			xCPF.value="";
			xCPF.focus();
			return false;	
			} 
		}	
		return true;
}

//-- Mascara_Valor: Coloca vírgula e pontos do valor digitado 
function mascara_valor(campo,tecla,ComSinal) // ComSinal (S)-sim (N)-não
{
	var milSep = '.';
	var decSep = ',';
    var myvalor = '';   
	var sep = 0;
	var key = '';
	var i = j = 0;
	var len = len2 = 0;
	var sinal = '';
	var strCheck = '0123456789';
	var aux = aux2 = '';
	var whichCode = (window.Event) ? tecla.which : tecla.keyCode;
	
	if (campo.readOnly ==true)
	    return false;
	
	if  (whichCode == 13)  
	    return true;

	key = String.fromCharCode(whichCode); 
	
	if  (ComSinal == 'S')
        {  
	     strCheck = '-0123456789';
         if  ((campo.value.indexOf('-') != -1) || (key == '-'))
	         {
	              sinal = '-';
	         } 
	    }  
 
 	if (strCheck.indexOf(key) == -1) 
	    return false; 

    var a = campo.value;
    campo.value = a.replace('-',''); 
    
   	len = campo.value.length;
	
	for(i = 0; i < len; i++)
	   {
	     if ((campo.value.charAt(i) != '0') && (campo.value.charAt(i) != decSep)) 
	          break;
	   }       
	aux = '';
	for(; i < len; i++)
	    {
	    if (strCheck.indexOf(campo.value.charAt(i))!=-1) 
	       aux += campo.value.charAt(i);
	    }   
	
	aux += key;
	if (key == '-')
		len = 0;
	else
		len = aux.length;
		
	if (len == 0) campo.value = sinal + '';
	if (len == 1) campo.value = sinal + '0'+ decSep + '0' + aux ;
	if (len == 2) campo.value = sinal + '0'+ decSep + aux;
	
	
	if (len > 2) 
	   {
		aux2 = '';
		for (j = 0, i = len - 3; i >= 0; i--) 
		    {
			 if (j == 3) 
			 {
				aux2 += milSep;
				j = 0;
			 }
			 aux2 += aux.charAt(i);
			 j++;
		    }
//		campo.value = '';
        campo.value = sinal;
		len2 = aux2.length;
		for (i = len2 - 1; i >= 0; i--)
		     campo.value += aux2.charAt(i);
    	campo.value += decSep + aux.substr(len - 2, len);
 	  }
 	return false;
}


//-- Mascara_Data: Coloca barras na data digitada
function mascara_data(data,objeto)
{
		var mydata = ''; 
		mydata = mydata + data; 
		if (mydata.length == 2){ 
		mydata = mydata + '/'; 
		eval('document.Form1.'+ objeto +'.value=mydata'); 
		} 
		if (mydata.length == 5){ 
		mydata = mydata + '/'; 
		eval('document.Form1.'+ objeto +'.value=mydata'); 
		} 
} 


//-- Checa_data: Testa validade da data digitada
function checa_data(xcampo)
{
		var campo = xcampo.value
		var datavalida = true;
		var quatro = true;
		if (campo!=""){
		if (campo.length < 8)
		datavalida = false
		else {
		dia = (campo.substr(0, 2));
		mes = (campo.substr(3, 2));
		ano = (campo.substr(6));
		if (AnoBissexto(ano) == true)
		var dias = new Array(31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31)
		else
		var dias = new Array(31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);

		if ((ano.length == 2) || (ano.length == 4)) 
		{
			if (ano.length == 2) {
				if (ano > 29) {
					ano = '19' + ano;
					}
				else    
					{
					ano = '20' + ano;
					}
				xcampo.value = dia + '/' + mes + '/' + ano;
			}	
		}
		else {
			quatro = false;
			}   
		   
		if ((ano < 1800) || (ano > 2999)) {
		datavalida = false;
		} else
		if ((mes < 1) || (mes > 12)) {
		datavalida = false;
		} else
		if ((dia < 1) || (dia > dias[mes-1])) {
		datavalida = false;
		}
		}
		}
		if (datavalida == false) {
		alert('Data Invalida');
		xcampo.value = "";
		xcampo.focus();
		}
		else if (quatro == false) {
		alert('Informe o ano com 2 ou 4 digitos');
		xcampo.value = "";
		xcampo.focus();
		}
		return datavalida;
}


function AnoBissexto(vAno) {
		if ((vAno % 4) == 0) 
		{
			return true; 
		}
			return false;
		}