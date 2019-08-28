import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    container: {
      marginTop: "5%",
      marginLeft: "2%",
      width: "100%",
      maxWidth: "40%"
    },
    cardStyle: {
      width: 150,
      marginRight: "1%",
      marginTop: "2%",
      maxHeight: 120,
      textDecoration: "none"
    },
    cardContainer: {
      display: "flex",
      flexWrap: "wrap"
    },
    noBoardContainer: {
      marginLeft: "2%"
    }
  })
);
