import React from "react";
import BoardActionButton from "../inputs/BoardActionButton";
import { DragDropContext } from "react-beautiful-dnd";
import { BoardViewModel, ColumnViewModel } from "../../models/models";
import { SortColumn } from "../../actions/board/BoardActions";
import TicketList from "../board/TicketList/TicketList";
import { useStyles } from "./BoardStyles";
import { connect } from "react-redux";

const mapStateToProps = (state: BoardViewModel) => {
  return {
    state: state
  };
};

const mapDispatchToProps = {
  SortColumn
};

const Board = (props: any) => {
  const classes = useStyles();

  const { SortColumn, state } = props;

  const onDragEnd = (result: any) => {
    const { destination, source, draggableId } = result;

    if (!destination) {
      return;
    }

    SortColumn(
      source.droppableId,
      destination.droppableId,
      source.index,
      destination.index,
      draggableId
    );
  };

  return (
    <DragDropContext onDragEnd={onDragEnd}>
      <div>
        <div className={classes.listContainer}>
          {state.board.columns.map((column: ColumnViewModel) => (
            <TicketList
              columnId={column.columnId}
              key={column.columnId}
              title={column.title}
              tickets={column.tickets}
            />
          ))}

          <div className={classes.buttonContainer}>
            <BoardActionButton boardId={state.board.boardId} isList={true} />
          </div>
        </div>
      </div>
    </DragDropContext>
  );
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(Board);