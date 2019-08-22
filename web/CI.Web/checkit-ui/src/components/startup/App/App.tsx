import React from "react";
import { useStyles } from "./AppStyles";
import Header from "../Header/Header";
import Main from "../Main/Main";
import Footer from "../Footer/Footer";
import "typeface-roboto";

export const App = () => {
  const classes = useStyles();

  return (
    <div>
      <Header />
      <Main />
      <Footer />
    </div>
  );
};

export default App;
