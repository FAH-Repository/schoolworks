export const rows = (rows) => {
  return !rows
      ? []
      : (function _(triangle, rowId) {
            if (rowId === rows) {
                return triangle;
            }
            const prev = triangle[rowId - 1];
            return _(
                [
                    ...triangle,
                    new Array(rowId + 1).fill(1).map((_item, index) => (prev[index - 1] || 0) + (prev[index] || 0)),
                ],
                rowId + 1
            );
        })([[1]], 1);
};