import Main from "../components/startup/Main/Main";
import Board from "../components/board/Board/Board";

export const routes = [
  {
    path: "/",
    component: Main
  },
  {
    path: "/board/:boardId",
    component: Board
  }
];
