import React from "react";
import { useStyles } from "./AppStyles";
import Login from "../../login/Login";
import "typeface-roboto";

export const App = () => {
  const classes = useStyles();

  return (
    <div className={classes.container}>
      <div className={classes.loginAligment}>
        <Login />
      </div>
    </div>
  );
};

export default App;
