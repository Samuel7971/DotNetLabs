window.dotNetLabs = window.dotNetLabs || {};

window.dotNetLabs.code = {
    copyFromElement: async function (element) {
        if (!element) {
            return;
        }

        const text = element.innerText || element.textContent || "";

        await navigator.clipboard.writeText(text.trim());
    }
};