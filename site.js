// DROPDOWNS
const dropdowns = document.querySelectorAll('[data-type="dropdown"]');

document.addEventListener('click', function (event) {
  let clickedDropdown = null;

  dropdowns.forEach(dropdown => {
    const targetId = dropdown.getAttribute('data-target');
    const targetElement = document.querySelector(targetId);

    if (dropdown.contains(event.target)) {
      clickedDropdown = targetElement;

      // Stäng andra öppna dropdowns
      document.querySelectorAll('.dropdown.dropdown-show').forEach(openDropdown => {
        if (openDropdown !== targetElement) {
          openDropdown.classList.remove('dropdown-show');
        }
      });

      targetElement.classList.toggle('dropdown-show');
    }
  });

  // Klick utanför dropdowns
  if (!clickedDropdown && !event.target.closest('.dropdown')) {
    document.querySelectorAll('.dropdown.dropdown-show').forEach(openDropdown => {
      openDropdown.classList.remove('dropdown-show');
    });
  }
});


// MODALS (Öppna)
const modals = document.querySelectorAll('[data-type="modal"]');

modals.forEach(modal => {
  modal.addEventListener('click', function () {
    const targetId = modal.getAttribute('data-target');
    const targetElement = document.querySelector(targetId);
    if (targetElement) {
      targetElement.classList.add('modal-show');
    }
  });
});

// MODALS (Stäng)
const closeButtons = document.querySelectorAll('[data-type="close"]');

closeButtons.forEach(button => {
  button.addEventListener('click', function () {
    const targetId = button.getAttribute('data-target');
    const targetElement = document.querySelector(targetId);
    if (targetElement) {
      targetElement.classList.remove('modal-sh
