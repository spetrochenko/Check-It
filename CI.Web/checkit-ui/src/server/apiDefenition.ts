import {
  CreateUserViewModel,
  CreateBoardViewModel,
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
  public async createBoard(boardViewModel: CreateBoardViewModel): Promise<any> {
    const response = await fetch("api/BoardController/CreateBoard", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(boardViewModel)
    });

    return await response.json();
  }

  public async loadBoards(): Promise<any> {
    const response = await fetch("api/BoardController/LoadAllBoards", {
      method: "GET",
      headers: { "Content-Type": "application/json" }
    });

    return await response.json();
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
