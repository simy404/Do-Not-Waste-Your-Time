
console.log("content-script.js");

const url = chrome.runtime.getURL('data/x.json');

fetch(url)
    .then((response) => response.json())
    .then((BlockedGroup) => logSites(BlockedGroup));


function logSites(data) {
    for (let i = 0; i < data.length; i++) {
        if(data[i].IsActive == false) continue;

        data[i].Sites.forEach(site => {
            if (window.location.href.includes(site.Url)) {
                console.log("Site: " + site);
                console.log("Category: " + data[i].VisiLogs);
                document.body.innerHTML = '';
                document.body.style.backgroundColor = "black";
                document.body.style.color = "white";
                document.body.style.fontSize = "50px";
                document.body.style.textAlign = "center";
                document.body.style.paddingTop = "100px";
                document.body.innerHTML = "This site is blocked by Simy";


            }
        });

    }
}