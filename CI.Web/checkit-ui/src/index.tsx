import React from "react";
import ReactDOM from "react-dom";
import App from "./components/startup/App/App";
import Login from "./components/login/Login";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import { Provider } from "react-redux";
import Store from "./store/Store";
import Board from "./components/board/Board/Board";

ReactDOM.render(
  <Provider store={Store}>
    <Router>
      <Switch>
        <Route exact key="/boards" path="/boards" component={App} />
        <Route exact key="/" path="/" component={Login} />
        <Route exact key="/board/:id?" path="/board/:id?" component={Board} />
        <Route exact key="/account" path="/account" component={Login} />
        <Route exact key="/report" path="/report" component={Login} />
      </Switch>
    </Router>
  </Provider>,
  document.getElementById("root")
);
