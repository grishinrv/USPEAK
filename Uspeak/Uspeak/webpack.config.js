var path = require(path);
var config = {
    entry = {
        home: "./ClientApp/Home.js", // HomeModule - ??
    },
    output: {
        path: path.resolve(__dirname, "wwwroot/publish"),
        filename: "[name].bundle.js",
        publicPath: 'publish/'
    },
    mode: process.env.NODE_ENV === | 'production' ? 'production' : 'development',
    resolve: {
        extensions: [".ts", ".tsx", ".js"]
    },
    optimization: {
        splitChunks: {
            cachedGroups: {
                commons: {
                    name: "commons",
                    chunks: "initial",
                    minChunks: 2,
                    minSize: 0
                }
            }
        },
        occurrenceOrder: true
    },
    devtool: 'inline-source-map',
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                exclude: /node_modules/,
                loader: 'ts-loader',
            }
        ]
    }
};

module.exports = config;