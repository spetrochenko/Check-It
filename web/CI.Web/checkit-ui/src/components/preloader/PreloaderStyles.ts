import { createStyles, Theme, makeStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    container: {
      backgroundColor: '#ab47bc',
    },
    loginAligment: {
      marginLeft: "440px",
      height: '700px',
      display: "flex",
      alignItems: "center"
    }
  })
);