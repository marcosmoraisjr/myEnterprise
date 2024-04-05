

// mudar cor ao receber foco
function ChangeColorFocus(obj, evt) {
    if (evt.type == "focus") {
        obj.style.borderColor = "#FF4D00";
    }
    else if (evt.type == "blur") {
        obj.style.borderColor = "#0a719c";
    }
}

    // fecha navegador
    function fechatudo() {
        var oMe = window.self;
        oMe.opener = window.self;
        oMe.close();
    }

    // determina sistema como padrão
    function DefaultButton(btn) {
        if (event.keyCode == 13) {
            event.returnValue = false;
            event.cancel = true;
            btn.click();
        }
    }

    /**************************************************************************
    Função para simular um Tab quando for pressionado a tecla Enter
    Exemplo: onKeyDown="TABEnter()"
    Funciona em TEXT BOX,RADIO BUTTON, CHECK BOX e menu DROP-DOWN
    **************************************************************************/
    function TABEnter(oEvent) {
        var oEvent = (oEvent) ? oEvent : event;
        var oTarget = (oEvent.target) ? oEvent.target : oEvent.srcElement;
        if (oEvent.keyCode == 13)
            oEvent.keyCode = 9;
        if (oTarget.type == "text" && oEvent.keyCode == 13)
        //return false;
            oEvent.keyCode = 9;
        if (oTarget.type == "radio" && oEvent.keyCode == 13)
            oEvent.keyCode = 9;
    }

    // marcos: A função abaixo faz a validação completa de uma 
    // data verificando ano bi-sexto, meses com 30 e 31 dias. 
    // como usar:  <INPUT TYPE="text" NAME="Data" onblur="validaDat(this,this.value)">
    function validaDat(campo, valor) {
        var date = valor;
        var ardt = new Array;
        var ExpReg = new RegExp("(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}");
        ardt = date.split("/");
        erro = false;
        if (date.search(ExpReg) == -1) {
            erro = true;
        }
        else if (((ardt[1] == 4) || (ardt[1] == 6) || (ardt[1] == 9) || (ardt[1] == 11)) && (ardt[0] > 30))
            erro = true;
        else if (ardt[1] == 2) {
            if ((ardt[0] > 28) && ((ardt[2] % 4) != 0))
                erro = true;
            if ((ardt[0] > 29) && ((ardt[2] % 4) == 0))
                erro = true;
        }
        if (erro) {
            alert("\"" + valor + "\" não é uma data válida!!!");
            campo.focus();
            campo.value = "";
            return false;
        }
        return true;
    }

    /* Marcos: Validação de campos em branco de um formulário
    JavaScript - DHTML / Validação
    Com este código, se o campo estiver assinalado que é obrigatório, então a função de validação irá verificá-lo quando o evento onSubmit do formulário for chamado. Deixei aqui duas formas, esta prime ...
    */
    function ValidaSemPreenchimento(form) {
        for (i = 0; i < form.length; i++) {
            var obg = form[i].obrigatorio;
            if (obg == 1) {
                if (form[i].value == "") {
                    var nome = form[i].name
                    alert("O campo " + nome + " é obrigatório.")
                    form[i].focus();
                    return false
                }
            }
        }
        return true
    }


    /*Marcos: Validar documento de identidade (RG)
    JavaScript - DHTML / Validação
    Com este código é possível através da função 
    (ValRG) validar o documento de identidade (RG). 
    Este tipo de validação é muito bom para evitar a entrada de 
    dados errados em um formulário por parte do ...

    <html><body>
    <script language="javascript">

    function nu(campo){
    var digits="0123456789"
    var campo_temp 
    for (var i=0;i<campo.value.length;i++){
    campo_temp=campo.value.substring(i,i+1) 
    if (digits.indexOf(campo_temp)==-1){
    campo.value = campo.value.substring(0,i);
    break;
    }
    }
    }

    function ValRG(numero){
 
     var numero = numero.split("");
    tamanho = numero.length;
    vetor = new Array(tamanho);

    if(tamanho>=1)
    {
    vetor[0] = parseInt(numero[0]) * 2; 
    }
    if(tamanho>=2){
    vetor[1] = parseInt(numero[1]) * 3; 
    }
    if(tamanho>=3){
    vetor[2] = parseInt(numero[2]) * 4; 
    }
    if(tamanho>=4){
    vetor[3] = parseInt(numero[3]) * 5; 
    }
    if(tamanho>=5){
    vetor[4] = parseInt(numero[4]) * 6; 
    }
    if(tamanho>=6){
    vetor[5] = parseInt(numero[5]) * 7; 
    }
    if(tamanho>=7){
    vetor[6] = parseInt(numero[6]) * 8; 
    }
    if(tamanho>=8){
    vetor[7] = parseInt(numero[7]) * 9; 
    }
    if(tamanho>=9){
    vetor[8] = parseInt(numero[8]) * 100; 
    }

     total = 0;

    if(tamanho>=1){
    total += vetor[0];
    }
    if(tamanho>=2){
    total += vetor[1]; 
    }
    if(tamanho>=3){
    total += vetor[2]; 
    }
    if(tamanho>=4){
    total += vetor[3]; 
    }
    if(tamanho>=5){
    total += vetor[4]; 
    }
    if(tamanho>=6){
    total += vetor[5]; 
    }
    if(tamanho>=7){
    total += vetor[6];
    }
    if(tamanho>=8){
    total += vetor[7]; 
    }
    if(tamanho>=9){
    total += vetor[8]; 
    }


     resto = total % 11;
    if(resto!=0){
    document.getElementById('camada').innerHTML="<font face=verdana size=2 color=red>RG Inválido!</font><br><br>";
    }
    else{
    document.getElementById('camada').innerHTML="<font face=verdana size=2 color=forestgreen>RG Válido!</font><br><br>";
    }
    }
    </script>
    <div align=center id=camada></div>
    <div align=center>
    <input type="text" id="rg" onKeyUp="nu(this)"> <input type=button value='Validar RG' onClick="if(document.getElementById('rg').value != ''){ValRG(document.getElementById('rg').value)}else{alert('RG em branco')}"></div>
    </body></html>
    */

    // marcos:pede confirmação para deletar algun registro
    function confirmDelete() {
        if (confirm('O registro será eliminado. Confirma?')) {
            return true;
        } else {
            return false;
        }
    }


    // marcos:desabilita o botão direito do mouse )
    function proteger() {
        //alert ("Esta função está desabilitada.\n\n. Desculpe o transtorno")
        return false
    }

    // marcos:impede o usuario desesperado clicar 2x no botão)
    function desabilitar(object) {
        window.status = "Aguarde...";
        document.body.style.cursor = 'wait';
        object.value = "Aguarde...";
        object.style.cursor = 'wait';
        object.disabled = true;
    }


    // marcos:função para gridview com efeito ( precisa da tag css moduleRow/moduleRowOver )
    var selected;
    function selectRowEffect(object) {

        if (!selected) {
            if (document.getElementById) {
                selected = document.getElementById('defaultSelected');
            } else {
                selected = document.all['defaultSelected'];
            }
        }

        if (selected) {
            selected.className = 'moduleRow';
        }
        object.className = 'moduleRowSelected';
        selected = object;
    }

    // marcos:função para gridview com efeito ( precisa da tag css moduleRow/moduleRowOver ) 
    function rowOverEffect(object) {

        if (object.className == 'moduleRow') {
            object.className = 'moduleRowOver';
        }
    }

    // marcos:função para gridview com efeito ( precisa da tag css moduleRow/moduleRowOver )
    function rowOutEffect(object) {

        if (object.className == 'moduleRowOver') {
            object.className = 'moduleRow';
        }
    }


    // marcos: checa senha
    function checkPassword(formulario) {
        var erro = "";
        if (formulario.txt_usuario.value == "") {
            alert("Favor digitar um nome de usuário.\n");
            formulario.txt_usuario.select();
            formulario.txt_usuario.focus();
            return false;
        }
        else {
            var illegalChars = /[\W_]/; // marcos: Aceita apenas letras e numeros
            if (illegalChars.test(formulario.txt_usuario.value)) {
                alert("Favor digitar apenas letras e números.\n");
                formulario.txt_usuario.select();
                formulario.txt_usuario.focus();
                return false;
            }
        }
        if (formulario.txt_senha.value == "") {
            alert("Favor digitar uma senha.\n");
            formulario.txt_senha.select();
            formulario.txt_senha.focus();
            return false;
        }
        else {
            var illegalChars = /[\W_]/; // marcos: Aceita apenas letras e numeros
            if (illegalChars.test(formulario.txt_senha.value)) {
                alert("Favor digitar apenas letras e números.\n");
                formulario.txt_senha.select();
                formulario.txt_senha.focus();
                return false;
            }
        }
        return true;
    }