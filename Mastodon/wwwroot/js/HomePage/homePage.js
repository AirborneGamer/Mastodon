﻿/*This script is for showing a custom promotion on the site*/

/*Begin Oso Easy Promo Script*/(function () { let a = new XMLHttpRequest; a.onreadystatechange = function () { if (4 === a.readyState) if (200 === a.status) { if (document.body.className = 'ok', !a.responseText || a.responseText.includes('ERROR') || a.responseText.includes('WARNING')) return void console.log(a.responseText); let b = document.createElement('script'); b.innerHTML = a.responseText, document.getElementsByTagName('head')[0].appendChild(b) } else console.log('OsO Easy Promo Error' + a.responseText) }, a.open('GET', 'https://api.osoeasypromo.com/api/promo/8899161c-1c6e-4a96-93fd-2870ffad82c4', !0), a.send(null) })();/*End Oso Easy Promo Script*/

function contactUs() {
    axios.get('SendContactRequest' + "?userEmail=" + $('#userEmail').val() + "&userComment=" + $('#userComment').val())
        .then(function (response) {
            $('#sendConfirmation').show();
        })
        .catch(function (error) {
            //todo Handle errors
        });
}