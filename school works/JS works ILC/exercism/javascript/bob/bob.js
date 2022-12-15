export const hey = message => {
  const allUpperCase = message => {
    return (
      message === message.toUpperCase() && /[a-z]/.test(message.toLowerCase())
    )
  }

  const endsWithQuestionMark = message => {
    return message.charAt(message.length - 1) === '?'
  }

  const onlyWhitespace = message => {
    return !message.replace(/\s/g, '').length
  }

  let trimmedMessage = message.trim()
  if (onlyWhitespace(message)) {
    return 'Fine. Be that way!'
  } else if (allUpperCase(trimmedMessage)) {
    if (endsWithQuestionMark(trimmedMessage)) {
      return "Calm down, I know what I'm doing!"
    } else {
      return 'Whoa, chill out!'
    }
  } else if (endsWithQuestionMark(trimmedMessage)) {
    return 'Sure.'
  }
  return 'Whatever.'
}