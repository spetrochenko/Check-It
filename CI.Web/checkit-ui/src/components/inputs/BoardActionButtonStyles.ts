import { makeStyles, createMuiTheme } from "@material-ui/core";
import { green } from "@material-ui/core/colors";

export const useStyle = makeStyles({
  textAreaContainer: {
    minWidth: 275,
    margin: 10,
    minHeight: 80
  },
  textArea: {
    resize: "none",
    width: "100%",
    outline: "none",
    border: "none",
    overflow: "hidden",
    fontSize: 14
  },
  button: {
    color: "white",
    textTransform: "none"
  },
  cancelButton: {
    marginLeft: 8,
    color: "212121",
    cursor: "pointer"
  },
  formButtonGroup: {
    display: "flex",
    alignItems: "center",
    marginLeft: 10
  },
  addlistButton: {
    minWidth: 275,
    width: "100%",
    color: "white",
    opacity: 1,
    backgroundColor: "#50B050",
    display: "flex"
  },
  addTicketButton: {
    minWidth: 275,
    margin: 9,
    width: "94%",
    color: "inherit",
    opacity: 0.5,
    backgroundColor: "inherit",
    display: "flex"
  },
  textStyle: {
    textTransform: "none"
  },
  formMargin: {
    marginTop: -10
  }
});

export const theme = createMuiTheme({
  palette: {
    primary: green
  }
});
