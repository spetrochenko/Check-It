import { createStyles, Theme, makeStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    container: {
      backgroundColor: "#fff",
      width: "500px",
      height: "500px",
      borderRadius: "20px",
      textAlign: "center",
      boxShadow:
        "0 20px 8px 0 rgba(0, 0, 0, 0.2), 0 20px 20px 0 rgba(0, 0, 0, 0.19)",
    },
    titleStyle: {
      paddingTop: "40px",
    },
    subTitleStyles: {
      paddingTop: "20px",
    },
    margin: {
      marginTop: theme.spacing(2),
      marginLeft: theme.spacing(10),
      marginBottom: theme.spacing(3)
    },
    textSize: {
        width: "340px"
    },
    registerButton: {
        width: "100px"
    }
  })
);
