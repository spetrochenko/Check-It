import React from "react";
import { Provider } from "react-redux";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import { Header } from "../../components/startup/Header/Header";
import { Footer } from "../../components/startup/Footer/Footer";
import { routes } from "../../routes/routes";

export const Root = (props: any) => {
  return (
    <div>
      <Provider store={props.store}>
        <Router>
          <Header />
          <Switch>
            {routes.map((route: any) => (
              <Route
                exact
                key={route.path}
                path={route.path}
                component={route.component}
              />
            ))}
          </Switch>
          <Footer />
        </Router>
      </Provider>
    </div>
  );
};

export default Root;
