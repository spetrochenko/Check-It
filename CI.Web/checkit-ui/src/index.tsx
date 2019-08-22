import React from "react";
import ReactDOM from "react-dom";
import App from "./components/startup/App/App";
import { Provider } from "react-redux";
import Store from "./store/Store";

ReactDOM.render(
  <Provider store={Store}>
    <App />
  </Provider>,
  document.getElementById("root")
);
