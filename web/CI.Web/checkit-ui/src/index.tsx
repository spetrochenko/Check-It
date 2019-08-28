import React from "react";
import ReactDOM from "react-dom";
import Root from "./components/root/Root";
import Store from "./store/Store";

ReactDOM.render(<Root store={Store} />, document.getElementById("root"));
