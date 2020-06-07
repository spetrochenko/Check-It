import React, { useState } from "react";
import Typography from "@material-ui/core/Typography";
import Card from "@material-ui/core/Card";
import AddIcon from "@material-ui/icons/Add";
import Icon from "@material-ui/core/Icon";
import { Button } from "@material-ui/core";
import { useStyle, theme } from "./BoardActionButtonStyles";
import { ThemeProvider } from "@material-ui/styles";
import TextareaAutosize from "@material-ui/core/TextareaAutosize";
import { connect } from "react-redux";
import { AddNewColumn } from "../../actions/board/BoardActions";
import { AddNewTicket } from "../../actions/column/ColumnActions";
import { CreateColumnViewModel } from "../../models/models";

const mapDispatchToProps = {
  AddNewColumn,
  AddNewTicket
};

export const BoardActionButton = (props: any) => {
  const classes = useStyle();
  const [isFormOpen, setFormOpen] = useState(false);
  const [title, setTitle] = useState();
  const { boardId, columnId, isList, AddNewColumn, AddNewTicket } = props;

  const formOptions = {
    placeholder: props.isList
      ? "Enter column title..."
      : "Enter ticket title...",
    buttonTitle: isList ? "Add column" : "Add ticket"
  };

  const handleAddList = () => {
    if (title) {
      const column: CreateColumnViewModel = {
        title: title,
        boardId: boardId
      };
      AddNewColumn(column.title);
      setTitle(title);
    }

    return;
  };

  const handleAddTicket = () => {
    if (title) {
      AddNewTicket(columnId, String(title));
      setTitle(title);
    }

    return;
  };

  const renderAddButton = () => {
    return (
      <div>
        <Button
          variant="contained"
          onClick={() => setFormOpen(true)}
          className={isList ? classes.addlistButton : classes.addTicketButton}
        >
          <AddIcon />
          <Typography
            align="center"
            variant="subtitle1"
            className={classes.textStyle}
          >
            {isList ? "Add another column" : "Add another ticket"}
          </Typography>
        </Button>
      </div>
    );
  };

  const renderForm = () => {
    return (
      <div className={isList ? classes.formMargin : undefined}>
        <Card className={classes.textAreaContainer}>
          <TextareaAutosize
            placeholder={formOptions.placeholder}
            autoFocus
            onBlur={() => setFormOpen(false)}
            value={title}
            onChange={event => {
              setTitle(event.target.value);
            }}
            className={classes.textArea}
            rows={4}
          />
        </Card>
        <div className={classes.formButtonGroup}>
          <ThemeProvider theme={theme}>
            <Button
              onMouseDown={isList ? handleAddList : handleAddTicket}
              variant="contained"
              color="primary"
              className={classes.button}
            >
              {formOptions.buttonTitle}
            </Button>
            <Icon className={classes.cancelButton}>close</Icon>
          </ThemeProvider>
        </div>
      </div>
    );
  };

  return isFormOpen ? renderForm() : renderAddButton();
};

export default connect(
  null,
  mapDispatchToProps
)(BoardActionButton);
