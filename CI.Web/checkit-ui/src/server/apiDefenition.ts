import {
  CreateUserViewModel,
  BoardViewModel,
  CreateColumnViewModel
} from "../models/models";

export class userApiController {
  public createUser(createUserViewModel: CreateUserViewModel): Promise<any> {
    return fetch("api/UserController/CreateUser", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(createUserViewModel)
    });
  }
}

export class boardApiController {
  public createBoard(boardViewModel: BoardViewModel): Promise<any> {
    return fetch("api/BoardController/CreateBoard", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(boardViewModel)
    });
  }

  public loadById(id: number): Promise<any> {
    return fetch("api/BoardController/LoadBoardById", { method: "GET" });
  }
}

export class columnApiController {
  public async createColumn(columnView: CreateColumnViewModel): Promise<any> {
    const response = await fetch("api/ColumnController/CreateColumn", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(columnView)
    });
    return await response.json();
  }
}
