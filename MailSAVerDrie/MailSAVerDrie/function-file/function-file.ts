/*
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

(() => {
  // The initialize function must be run each time a new page is loaded
  Office.initialize = () => {
 // Checks for the DOM to load.
 $(document).ready(function () {
  // After the DOM is loaded, add-in-specific code can run.
  var mailbox = Office.context.mailbox;
  _Item = mailbox.item;
});
  };

  // Add any ui-less function here
})();
