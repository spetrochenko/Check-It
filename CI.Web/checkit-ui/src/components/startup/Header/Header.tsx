import React, { useState } from "react";
import { useStyles } from "./HeaderStyles";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import IconButton from "@material-ui/core/IconButton";
import Typography from "@material-ui/core/Typography";
import Menu from "@material-ui/core/Menu";
import MenuIcon from "@material-ui/icons/Menu";
import { MenuItem, Button } from "@material-ui/core";
import AuthForm from "../../forms/authForm/AuthForm";

export const Header = () => {
  const classes = useStyles();
  const [anchorElement, setAnchorElement] = useState<null | HTMLElement>(null);
  const [
    mobileMoreAnchorElement,
    setMobileMoreAnchorElement
  ] = useState<null | HTMLElement>(null);
  const [isDialogOpen, setDialogOpen] = useState(false);
  const [isSignIn, setSignIn] = useState();

  const isMenuOpen = Boolean(anchorElement);
  const isMobileMenuOpen = Boolean(mobileMoreAnchorElement);

  function handleMobileMenuClose() {
    setMobileMoreAnchorElement(null);
  }

  function handleMenuClose() {
    setAnchorElement(null);
    handleMobileMenuClose();
  }

  function handleOpenSignInDialog() {
    setSignIn(true);
    setDialogOpen(true);
  }

  function handleOpenSignUpDialog() {
    setSignIn(false);
    setDialogOpen(true);
  }

  function handleMobileMenuOpen(event: React.MouseEvent<HTMLElement>) {
    setMobileMoreAnchorElement(event.currentTarget);
  }

  const menuId = "primary-search-account-menu";
  const renderMenu = (
    <Menu
      anchorEl={anchorElement}
      anchorOrigin={{ vertical: "top", horizontal: "right" }}
      id={menuId}
      keepMounted
      transformOrigin={{ vertical: "top", horizontal: "right" }}
      open={isMenuOpen}
      onClose={handleMenuClose}
    />
  );

  const mobileMenuId = "primary-search-account-menu-mobile";
  const renderMobileMenu = (
    <Menu
      anchorEl={mobileMoreAnchorElement}
      anchorOrigin={{ vertical: "top", horizontal: "right" }}
      id={mobileMenuId}
      keepMounted
      transformOrigin={{ vertical: "top", horizontal: "right" }}
      open={isMobileMenuOpen}
      onClose={handleMobileMenuClose}
    >
      <MenuItem onClick={handleMobileMenuClose}>Sign In</MenuItem>
      <MenuItem onClick={handleMobileMenuClose}>Sign Up</MenuItem>
    </Menu>
  );

  return (
    <div className={classes.grow}>
      <AppBar position="sticky" color="primary">
        <Toolbar>
          <Typography className={classes.title} variant="h6" noWrap>
            Check-it!
          </Typography>
          <div className={classes.grow} />
          <div className={classes.sectionDesktop}>
            <Button onClick={handleOpenSignInDialog}>
              <Typography className={classes.buttonText}>Sign In</Typography>
            </Button>
            <Button onClick={handleOpenSignUpDialog}>
              <Typography className={classes.buttonText}>Sign Up</Typography>
            </Button>
          </div>
          <div className={classes.sectionMobile}>
            <IconButton
              aria-label="Show more"
              aria-controls={mobileMenuId}
              aria-haspopup="true"
              onClick={handleMobileMenuOpen}
              color="inherit"
            >
              <MenuIcon />
            </IconButton>
          </div>
        </Toolbar>
      </AppBar>
      {renderMobileMenu}
      {renderMenu}
      <AuthForm
        setDialogOpen={setDialogOpen}
        isOpen={isDialogOpen}
        isSignIn={isSignIn}
      />
    </div>
  );
};

export default Header;
