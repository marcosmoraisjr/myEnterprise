﻿/*
Marcos: mascaras

todo sistema web há uma necessidade de digitar campos que contenham 
somente números inteiros, datas entre outros.
O problema maior é que o próprio Visual Studio não tem uma máscara nativa para asp.net, 
somente existe do AjaxToolkit http://www.asp.net/AJAX/AjaxControlToolkit/Samples/MaskedEdit/MaskedEdit.aspx 
que não atende a vários requisitos e trava demais o usuário não deixando 
uma aparência boa no campo segundo várias pessoas com quem converso e eu próprio acho também.

formataValor    - valor monetário.
formataCEP      – para campos CEP;
formataCNPJ     – para campos CNPJ;
formataCPF      - para campos CPF;
formataRG       - para campos RG;
formataData     – para campos data (dd/MM/yyyy);
formataMesAno   – para campos que somente aceitam o mês e o ano juntos (MM/yyyy);
formataHora     – para campos hora (HH:mm);
formataInteiro  – para campos aonde só aceitam números inteiros;
formataDouble   – para números flutuantes Ex: 3,14159265;
formataTelefone – para campos com só com telefone sem DDD (0000-0000);
*/

// Marcos: Formata qualquer campo
// exemplo:onkeypress="formatar(this,'#####-###')"
function formataR(src, mask) {
    var i = src.value.length;
    var saida = mask.substring(0, 1);
    var texto = mask.substring(i)
    if (texto.substring(0, 1) != saida) {
        src.value += texto.substring(0, 1);
    }
}

// Marcos: Formata o campo valor monetário 
function formatarValor(campo, evt) {
    //1.000.000,00 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam <= 2) {
        campo.value = vr;
    }
    if ((tam > 2) && (tam <= 5)) {
        campo.value = vr.substr(0, tam - 2) + ',' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 6) && (tam <= 8)) {
        campo.value = vr.substr(0, tam - 5) + '.' + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 9) && (tam <= 11)) {
        campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 12) && (tam <= 14)) {
        campo.value = vr.substr(0, tam - 11) + '.' + vr.substr(tam - 11, 3) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 15) && (tam <= 18)) {
        campo.value = vr.substr(0, tam - 14) + '.' + vr.substr(tam - 14, 3) + '.' + vr.substr(tam - 11, 3) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
    }
}
// Formata data no padrão DD/MM/YYYY 
function formatarData(campo, evt) {
    //dd/MM/yyyy 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam >= 2 && tam < 4)
        campo.value = vr.substr(0, 2) + '/' + vr.substr(2);
    if (tam == 4)
        campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/';
    if (tam > 4)
        campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/' + vr.substr(4);
    //if (tam >= 5 && tam <= 10) 
    // campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/' + vr.substr(4, 4); 
}
// Formata só números 
function formatarInteiro(campo, evt) {
    //1234567890 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    campo.value = filtraNumeros(filtraCampo(campo));
}
// Formata hora no padrao HH:MM 
function formatarHora(campo, evt) {
    //HH:mm 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    if (tam == 2)
        campo.value = vr.substr(0, 2) + ':';
    if (tam > 2 && tam < 5)
        campo.value = vr.substr(0, 2) + ':' + vr.substr(2);
}
// Formata o campo quando é digitado somente o mês e o ano 
function formatarMesAno(campo, evt) {
    //MM/yyyy 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam > 2 && tam < 5)
        campo.value = vr.substr(0, tam - 2) + '/' + vr.substr(tam - 2, tam);
    if (tam >= 5 && tam <= 10)
        campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 4);
}
// Formata o campo CNPJ 
function formatarCNPJ(campo, evt) {
    //99.999.999/9999-99 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam <= 2) {
        campo.value = vr;
    }
    if ((tam > 2) && (tam <= 6)) {
        campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 7) && (tam <= 9)) {
        campo.value = vr.substr(0, tam - 6) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 10) && (tam <= 12)) {
        campo.value = vr.substr(0, tam - 9) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 13) && (tam <= 14)) {
        campo.value = vr.substr(0, tam - 12) + '.' + vr.substr(tam - 12, 3) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 15) && (tam <= 17)) {
        campo.value = vr.substr(0, tam - 14) + '.' + vr.substr(tam - 14, 3) + '.' + vr.substr(tam - 11, 3) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
}
// Formata o campo CPF 
function formatarCPF(campo, evt) {
    //999.999.999-99 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam <= 2) {
        campo.value = vr;
    }
    if (tam > 2 && tam <= 5) {
        campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
    }
    if (tam >= 6 && tam <= 8) {
        campo.value = vr.substr(0, tam - 5) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
    if (tam >= 9 && tam <= 11) {
        campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
}
//Marcio:Formata CPF e CNPJ juntos (Testando!)
function formatarCPF_CNPJ(campo, evt) {
    //999.999.999-99 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraCampo(campo);
    tam = vr.length;
    if (tam <= 11) {
        if (tam <= 2) {
            campo.value = vr;
        }
        if (tam > 2 && tam <= 5) {
            campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
        }
        if (tam >= 6 && tam <= 8) {
            campo.value = vr.substr(0, tam - 5) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
        }
        if (tam >= 9 && tam <= 11) {
            campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
        }

    }
    else {
        if (tam <= 2) {
            campo.value = vr;
        }
        if ((tam > 2) && (tam <= 6)) {
            campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
        }
        if ((tam >= 7) && (tam <= 9)) {
            campo.value = vr.substr(0, tam - 6) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
        }
        if ((tam >= 10) && (tam <= 12)) {
            campo.value = vr.substr(0, tam - 9) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
        }
        if ((tam >= 13) && (tam <= 14)) {
            campo.value = vr.substr(0, tam - 12) + '.' + vr.substr(tam - 12, 3) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
        }
        if ((tam >= 15) && (tam <= 17)) {
            campo.value = vr.substr(0, tam - 14) + '.' + vr.substr(tam - 14, 3) + '.' + vr.substr(tam - 11, 3) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
        }

    }
}
// Formata campo flutuante, permite números e somente uma vírgula 
function formatarDouble(campo, evt) {
    //18,53012 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    campo.value = filtraNumerosComVirgula(campo.value);
}
// Formata campo telefone 
function formatarTelefone(campo, evt) {
    //0000-0000 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraCampo(campo);
    tam = vr.length;
    if (tam <= 4)
        campo.value = vr;
    if (tam > 4)
        campo.value = vr.substr(0, tam - 4) + '-' + vr.substr(tam - 4, tam);
}
// Formata o campo CEP 
function formatarCEP(campo, evt) {
    //312555-650 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    vr = campo.value = filtraNumeros(filtraCampo(campo));
    tam = vr.length;
    if (tam <= 3)
        campo.value = vr;
    if (tam > 2)
        campo.value = vr.substr(0, tam - 3) + '-' + vr.substr(tam - 3, tam);

}
// Formata o campo Cartão de Crédito 
function formatarCartaoCredito(campo, evt) {
    //0000.0000.0000.0000 
    evt = getEvent(evt);
    var tecla = getKeyCode(evt);
    if (!teclaValida(tecla))
        return;
    var vr = campo.value = filtraNumeros(filtraCampo(campo));
    var tammax = 16;
    var tam = vr.length;
    if (tam < tammax && tecla != 8)
    { tam = vr.length + 1; }
    if (tam < 5)
    { campo.value = vr; }
    if ((tam > 4) && (tam < 9))
    { campo.value = vr.substr(0, 4) + '.' + vr.substr(4, tam - 4); }
    if ((tam > 8) && (tam < 13))
    { campo.value = vr.substr(0, 4) + '.' + vr.substr(4, 4) + '.' + vr.substr(8, tam - 4); }
    if (tam > 12)
    { campo.value = vr.substr(0, 4) + '.' + vr.substr(4, 4) + '.' + vr.substr(8, 4) + '.' + vr.substr(12, tam - 4); }
}
// limpa todos os caracteres especiais do campo solicitado 
function filtrarCampo(campo) {
    var s = "";
    var cp = "";
    vr = campo.value;
    tam = vr.length;
    for (i = 0; i < tam; i++) {
        if (vr.substring(i, i + 1) != "/"
&& vr.substring(i, i + 1) != "-"
&& vr.substring(i, i + 1) != "."
&& vr.substring(i, i + 1) != ":"
&& vr.substring(i, i + 1) != ",") {
            s = s + vr.substring(i, i + 1);
        }
    }
    return s;
    //return campo.value.replace("/", "").replace("-", "").replace(".", "").replace(",", "") 
}
// limpa todos caracteres que não são números 
function filtrarNumeros(campo) {
    var s = "";
    var cp = "";
    vr = campo;
    tam = vr.length;
    for (i = 0; i < tam; i++) {
        if (vr.substring(i, i + 1) == "0" ||
vr.substring(i, i + 1) == "1" ||
vr.substring(i, i + 1) == "2" ||
vr.substring(i, i + 1) == "3" ||
vr.substring(i, i + 1) == "4" ||
vr.substring(i, i + 1) == "5" ||
vr.substring(i, i + 1) == "6" ||
vr.substring(i, i + 1) == "7" ||
vr.substring(i, i + 1) == "8" ||
vr.substring(i, i + 1) == "9") {
            s = s + vr.substring(i, i + 1);
        }
    }
    return s;
    //return campo.value.replace("/", "").replace("-", "").replace(".", "").replace(",", "") 
}
// limpa todos caracteres que não são números, menos a vírgula 
function filtrarNumerosComVirgula(campo) {
    var s = "";
    var cp = "";
    vr = campo;
    tam = vr.length;
    var complemento = 0; //flag paga contar o número de virgulas 
    for (i = 0; i < tam; i++) {
        if ((vr.substring(i, i + 1) == "," && complemento == 0 && s != "") ||
vr.substring(i, i + 1) == "0" ||
vr.substring(i, i + 1) == "1" ||
vr.substring(i, i + 1) == "2" ||
vr.substring(i, i + 1) == "3" ||
vr.substring(i, i + 1) == "4" ||
vr.substring(i, i + 1) == "5" ||
vr.substring(i, i + 1) == "6" ||
vr.substring(i, i + 1) == "7" ||
vr.substring(i, i + 1) == "8" ||
vr.substring(i, i + 1) == "9") {
            if (vr.substring(i, i + 1) == ",")
                complemento = complemento + 1;
            s = s + vr.substring(i, i + 1);
        }
    }
    return s;
}
//recupera tecla 
//evita criar mascara quando as teclas são pressionadas
function ValidarTecla(tecla) {
    if (tecla == 8 //backspace
|| tecla == 9 //TAB
|| tecla == 45 //insert 
|| tecla == 46 //delete 
|| tecla == 36 //home 
|| tecla == 37 //esquerda 
|| tecla == 38 //cima 
|| tecla == 39 //direita 
|| tecla == 40)//baixo 
        return false;
    else
        return true;
}
// recupera o evento do form 
function getEvent(evt) {
    if (!evt) evt = window.event; //IE 
    return evt;
}
//Recupera o código da tecla que foi pressionado 
function getKeyCode(evt) {
    var code;
    if (typeof (evt.keyCode) == 'number')
        code = evt.keyCode;
    else if (typeof (evt.which) == 'number')
        code = evt.which;
    else if (typeof (evt.charCode) == 'number')
        code = evt.charCode;
    else
        return 0;
    return code;
}