import React, { useState } from "react";
import { useStyles } from "./HeaderStyles";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import Typography from "@material-ui/core/Typography";

export const Header = () => {
  const classes = useStyles();
  const [
    mobileMoreAnchorElement,
    setMobileMoreAnchorElement,
  ] = useState<null | HTMLElement>(null);

  return (
    <div className={classes.grow}>
      <AppBar position="sticky" color="primary">
        <Toolbar>
          <Typography className={classes.title} variant="h6" noWrap>
            Check-it!
          </Typography>
          <div className={classes.grow} />
          <div className={classes.sectionDesktop}>
          <Typography variant="body2" style={{
              marginTop: "5px",
              marginRight: "20px",
              textAlign: "center"
            }}>
              Reports
            </Typography>
            <Typography variant="body2" style={{
              marginTop: "5px",
              marginRight: "20px",
              textAlign: "center"
            }}>
              Account
            </Typography>
            <Typography variant="h6" noWrap>
              Hi, Siarhei!
            </Typography>
          </div>
        </Toolbar>
      </AppBar>
    </div>
  );
};

export default Header;
