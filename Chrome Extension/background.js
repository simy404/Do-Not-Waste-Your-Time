/**
 * background.js
 */
chrome.tabs.onUpdated.addListener((tabId, changeInfo, tab) => {
    console.log("sa");
    if (changeInfo.status === 'complete' && tab.active) {
        console.log("sa");
    }
});

  