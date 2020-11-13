import {setWasmOptions, TONClient} from 'ton-client-web-js';

setWasmOptions({    
    debugLog: message=>console.debug(message),    
    binaryURL: '_content/ch1seL.TonClientBlazor/js/tonclient.wasm',
});

window.createTonClient = async options => {
    if (window.tonClient === undefined){        
        window.tonClient = await TONClient.create(options);
        window.tonClient.completeErrorData = (data) => {
            console.log(data);
            JSON.stringify(data);
        }
    }    
}

window.closeTonClient = async () => {
    if (window.tonClient !== undefined){
        window.tonClient = await TONClient.close();
        window.tonClient = undefined;
    }
}

window.execute = async function(functionName) {
    const args = Array.prototype.slice.call(arguments).splice(1);
    const namespaces = functionName.split(".");
    const func = namespaces.pop();
    let ns = namespaces.join('.');
    if (ns === '') {
        ns = 'window';
    }
    ns = eval(ns);
    try {
        return await ns[func].apply(ns, args);
    } catch (e) {
        throw (typeof e == "string")
            ? e
            : JSON.stringify(e);
    }
}

window.getContactPackage = async (b64moduleData) => {    
    const module = await import(/* webpackIgnore: true */b64moduleData);
    return module.default.package;
}