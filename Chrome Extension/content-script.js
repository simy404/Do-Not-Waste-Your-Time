const url = chrome.runtime.getURL('data/x.json');
fetch(url)
    .then((response) => response.json()

    )
    .then((BlockedGroup) => logSites(BlockedGroup));

function logSites(data) {
    for (let i = 0; i < data.length; i++) {

        if(data[i].IsActive === false)
            continue;

        data[i].Sites.forEach(site => {
            if (window.location.href.includes(site.Url)) {
                blockSite();
                site.Id = 20;

                /*
                site = { ...site, Id: 20};
                fetch(url, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json;charset=utf-8',
                    },
                    body: JSON.stringify(site),
                })

                */
                /*

                var datas = JSON.stringify(data, undefined, 4)
                var blob = new Blob([data], {type: 'text/json'}),
                    e    = document.createEvent('MouseEvents'),
                    a    = document.createElement('a')
                var filename = 'console.json';
                a.download = filename;
                a.href = window.URL.createObjectURL(blob);
                a.dataset.downloadurl =  ['text/json', a.download, a.href].join(':')
                e.initMouseEvent('click', true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null)
                a.dispatchEvent(e)
                 */

                localStorage.setItem('blockedSites', JSON.stringify(data));
            }
        });
    }
}

function blockSite() {
    document.body.innerHTML = '';
    document.body.style.backgroundColor = "black";
    document.body.style.color = "white";
    document.body.style.fontSize = "50px";
    document.body.style.textAlign = "center";
    document.body.style.paddingTop = "100px";
    document.body.innerHTML = "This site is blocked by Simy";
}