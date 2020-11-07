const path = require('path');
const CopyPlugin = require('copy-webpack-plugin');

const opts = {
    rootDir: process.cwd(),
    //todo: have to passed MSBuildStartupDirectory variable here
    outputPath: path.join('..', 'wwwroot', 'js') 
};

module.exports = {
    output: {
        path: path.join(opts.rootDir, opts.outputPath),
        filename: 'tonclient.js'
    },
    stats: {
        warnings: false
    },
    plugins: [
        new CopyPlugin({
            patterns: [
                {from: path.resolve(__dirname, "node_modules/ton-client-web-js/tonclient.wasm")},
            ],
        })
    ],
};