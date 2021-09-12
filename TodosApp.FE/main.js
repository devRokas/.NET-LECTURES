// variables
const todoForm = document.getElementById("todo-form");
const todoList = document.getElementById("todos");
const doneList = document.getElementById("dones");

const todoTitle = document.getElementById("todo-title");
const todoDescription = document.getElementById("todo-description");
const todoDifficulty = document.getElementById("todo-difficulty");

const editTitle = document.getElementById("edit-title");
const editDescription = document.getElementById("edit-description");

let currentId;

function generateTodoItemHtml(todoItem) {
  return `
  <div class="border border-1 shadow-sm p-3 mb-3 rounded todo-item" data-id=${todoItem.id}>
      <h4 id="todoItem-title" class="mb-3 input-name">${todoItem.title}</h4>
      <p id="todoItem-description" class="mb-3 input-name">${todoItem.description}</p>
      <p class="mb-3 input-name">${todoItem.difficulty}</p>
      <button type="button" class="btn btn-danger delete">Delete</button>
      <button type="button" class="btn btn-success move-todo">${!todoItem.isDone ? "Move to done" : "Move back"}</button>
      <button type="button" class="btn btn-warning edit" data-bs-toggle="modal"
          data-bs-target="#edit-modal">Edit</button>
  </div>
  `;
}

window.onload = async () => {
  const todos = await getTodos();

  todos.forEach(todoItem => {
    if (!todoItem.isDone) {
      todoList.innerHTML += generateTodoItemHtml(todoItem);

      return;
    }
    
    doneList.innerHTML += generateTodoItemHtml(todoItem);
  });
};

todoForm.addEventListener("submit", async function (e) {
  e.preventDefault();

  const todoItem = {
    title: todoTitle.value,
    description: todoDescription.value,
    difficulty: todoDifficulty.value
  };

  await createTodo(todoItem);

  todoForm.reset();

  location.reload();
});

// Todo item card actions
document.addEventListener("click", async function (e) {
  if (e.target.matches(".delete")) {
    const id = e.target.closest(".todo-item").getAttribute("data-id");

    await deleteTodo(id);

    location.reload();

    return;
  }

  if (e.target.matches(".edit")) {
    const todoItem = e.target.closest(".todo-item");
    
    const title = todoItem.querySelector("#todoItem-title").innerText;
    const description = todoItem.querySelector("#todoItem-description").innerText;
    currentId = todoItem.getAttribute("data-id");

  
    editTitle.value = title;
    editDescription.value = description;
  }

  if (e.target.matches("#edit-submit")) {

      const request = {
      id: currentId,
      title: editTitle.value,
      description: editDescription.value,
    };

    await updateTodo(request)

    location.reload();
  }

  if (e.target.matches(".move-todo")) {
    const todoItem = e.target.closest(".todo-item");
    const id = todoItem.getAttribute("data-id");
        
    await updateTodoStatus(id);

    location.reload();
  }
});
