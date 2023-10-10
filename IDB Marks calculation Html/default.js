window.onload = function () {
    var txt01 = document.getElementById("txt01");
    var txt02 = document.getElementById("txt02");
    var txt03 = document.getElementById("txt03");
    var txt04 = document.getElementById("txt04");
    var txt_total = document.getElementById("txt_total");
    var txt_status = document.getElementById("txt_status");
    var btn_Cal = document.getElementById("btn_Cal");
    var btn_clr = document.getElementById("btn_clr");

    txt01.maxLength = 2;
    txt02.maxLength = 2;

    btn_Cal.onclick = function () {
        var num1 = parseInt(txt01.value, 10);

        if (num1 < 20 && txt01.value === "") {

        }
        else if (num1 > 50 && txt01.value !== "") {
            txt01.value = "50";
            alert("Maximum Number is 50");
            txt01.value = "";
        }

        var num2 = parseInt(txt02.value, 10);

        if (num2 < 32 && txt02.value === "") {

        }
        else if (num2 > 50 && txt02.value !== "") {
            txt02.value = "50";
            alert("Maximum Number is 50");
            txt02.value = "";
        }

        var total1 = Math.round(num1 * 0.20 * 100) / 100;

        txt03.value = total1;

        var total2 = Math.round(num2 * 0.80 * 100) / 100;

        txt04.value = total2;

        var total = Math.round(num1 * .20 + num2 * .80);

        txt_total.value = total;

        if (total >= 30) {
            txt_status.value = "Passed";
        }
        else {
            txt_status.value = "Failed";
        }
    };

    btn_clr.onclick = function () {
        txt01.value = "";
        txt02.value = "";
        txt03.value = "";
        txt04.value = "";
        txt_total.value = "";
        txt_status.value = "";
    };
};
